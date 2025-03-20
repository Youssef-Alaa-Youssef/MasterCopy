using Factory.DAL.Models.AI;
using System.Text.Json;
using System.Text;

namespace Factory.PL.Services.AI
{
    public class FreeAIChatService : IAIChatService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _apiEndpoint;

        public FreeAIChatService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;

            _apiEndpoint = _configuration["AIService:Endpoint"] ??
                           "https://api.openai.com/v1/completions"; // Default fallback
        }

        public async Task<ChatResponse> GetResponseAsync(string message)
        {
            try
            {
                return await UseOpenAICompatibleAPI(message);

                // Option 2: Use Hugging Face API
                // return await UseHuggingFaceAPI(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AI service: {ex.Message}");

                return new ChatResponse
                {
                    Message = "I'm sorry, I'm having trouble connecting to my brain right now. Please try again in a moment.",
                    IsError = true
                };
            }
        }

        private async Task<ChatResponse> UseOpenAICompatibleAPI(string message)
        {
            var request = new
            {
                model = _configuration["AIService:ModelName"] ?? "gpt-3.5-turbo", // Or your local model name
                messages = new[]
                {
                    //new { role = "system", content = "You are a helpful assistant." },
                    new { role = "user", content = message }
                },
                temperature = 0.7,
                max_tokens = 5
            };

            var content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json");

            string apiKey = _configuration["AIService:ApiKey"];
            if (!string.IsNullOrEmpty(apiKey))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
            }

            var response = await _httpClient.PostAsync(_apiEndpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var responseObject = JsonSerializer.Deserialize<JsonElement>(responseString, options);

                string responseText;

                if (responseObject.TryGetProperty("choices", out var choices) &&
                    choices.GetArrayLength() > 0 &&
                    choices[0].TryGetProperty("message", out var messageObj) &&
                    messageObj.TryGetProperty("content", out var contentElement))
                {
                    responseText = contentElement.GetString();
                }
                else if (responseObject.TryGetProperty("choices", out var choicesElement) &&
                         choicesElement.GetArrayLength() > 0 &&
                         choicesElement[0].TryGetProperty("text", out var textElement))
                {
                    responseText = textElement.GetString();
                }
                else
                {
                    responseText = "I received a response, but I couldn't understand it.";
                }

                return new ChatResponse
                {
                    Message = responseText?.Trim() ?? "No response",
                    IsError = false
                };
            }

            return new ChatResponse
            {
                Message = $"I'm having trouble connecting right now (Status: {response.StatusCode}).",
                IsError = true
            };
        }

        private async Task<ChatResponse> UseHuggingFaceAPI(string message)
        {

            var request = new
            {
                inputs = new
                {
                    text = message
                }
            };

            var content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json");

            string apiKey = _configuration["AIService:HuggingFaceApiKey"];
            if (!string.IsNullOrEmpty(apiKey))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiKey);
            }

            string modelEndpoint = _configuration["AIService:HuggingFaceModel"] ??
                                  "gpt2"; 

            var huggingFaceEndpoint = $"https://api-inference.huggingface.co/models/{modelEndpoint}";

            var response = await _httpClient.PostAsync(huggingFaceEndpoint, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

                try
                {
                    var responseObject = JsonSerializer.Deserialize<JsonElement>(responseString, options);

                    if (responseObject.ValueKind == JsonValueKind.Array && responseObject.GetArrayLength() > 0 &&
                        responseObject[0].TryGetProperty("generated_text", out var textElement))
                    {
                        return new ChatResponse
                        {
                            Message = textElement.GetString()?.Trim() ?? "No response",
                            IsError = false
                        };
                    }
                }
                catch (JsonException)
                {
                }

                return new ChatResponse
                {
                    Message = "I received a response, but couldn't parse it properly.",
                    IsError = true
                };
            }

            return new ChatResponse
            {
                Message = $"I'm having trouble with the Hugging Face API (Status: {response.StatusCode}).",
                IsError = true
            };
        }
    }

}
