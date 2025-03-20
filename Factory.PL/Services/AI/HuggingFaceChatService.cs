using Factory.DAL.Models.AI;
using System.Text.Json;
using System.Text;

namespace Factory.PL.Services.AI
{
    public class HuggingFaceChatService : IAIChatService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiToken;
        private readonly string _modelUrl;

        public HuggingFaceChatService(IConfiguration configuration, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiToken = configuration["HuggingFace:ApiToken"]; 
            _modelUrl = "https://api-inference.huggingface.co/models/facebook/blenderbot-400M-distill"; // Free model

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_apiToken}");
        }

        public async Task<ChatResponse> GetResponseAsync(string message)
        {
            try
            {
                var requestBody = new { inputs = message };

                var content = new StringContent(
                    JsonSerializer.Serialize(requestBody),
                    Encoding.UTF8,
                    "application/json");

                var response = await _httpClient.PostAsync(_modelUrl, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var responseObject = JsonSerializer.Deserialize<JsonElement>(responseBody);

                string responseMessage = responseObject[0].GetProperty("generated_text").GetString();

                return new ChatResponse
                {
                    Message = responseMessage,
                    IsError = false
                };
            }
            catch (Exception ex)
            {
                return new ChatResponse
                {
                    Message = $"Error: {ex.Message}",
                    IsError = true
                };
            }
        }
    }
}
