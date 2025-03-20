using Factory.DAL.Models.AI;

namespace Factory.PL.Services.AI
{
    public class LocalRuleBasedChatService : IAIChatService
    {
        private readonly Dictionary<string, string> _responses;

        public LocalRuleBasedChatService()
        {
            _responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "hello", "Hi there! How can I help you today?" },
                { "hi", "Hello! What can I assist you with?" },
                { "how are you", "I'm functioning well, thank you for asking! How can I help you?" },
                { "help", "I can help answer questions, provide information, or assist with tasks. What do you need?" },
                { "bye", "Goodbye! Have a great day!" },
                { "thank you", "You're welcome! Is there anything else you need help with?" }
                // Add more rules as needed
            };
        }

        public Task<ChatResponse> GetResponseAsync(string message)
        {
            string response = "I'm not sure how to respond to that. Could you ask something else?";

            if (_responses.TryGetValue(message.Trim(), out string exactMatch))
            {
                response = exactMatch;
            }
            else
            {
                foreach (var key in _responses.Keys)
                {
                    if (message.Contains(key, StringComparison.OrdinalIgnoreCase))
                    {
                        response = _responses[key];
                        break;
                    }
                }
            }

            return Task.FromResult(new ChatResponse
            {
                Message = response,
                IsError = false
            });
        }
    }

}
