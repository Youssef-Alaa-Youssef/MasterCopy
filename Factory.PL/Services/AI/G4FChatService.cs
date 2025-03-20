using Factory.DAL.Models.AI;
using System.Text.Json;
using System.Text;

namespace Factory.PL.Services.AI
{
    public class G4FChatService : IAIChatService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public G4FChatService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiUrl = "https://api.g4f.one/chat/completions"; 
        }

        public async Task<ChatResponse> GetResponseAsync(string message)
        {
            try
            {
                var requestBody = new
                {
                    messages = new[]
                    {
                        new { role = "user", content = message }
                    },
                    model = "gpt-3.5-turbo", 
                    stream = false
                };

                var content = new StringContent(
                    JsonSerializer.Serialize(requestBody),
                    Encoding.UTF8,
                    "application/json");

                var response = await _httpClient.PostAsync(_apiUrl, content);
                response.EnsureSuccessStatusCode();

                var responseBody = await response.Content.ReadAsStringAsync();
                var responseObject = JsonSerializer.Deserialize<JsonElement>(responseBody);

                var responseMessage = responseObject
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

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
