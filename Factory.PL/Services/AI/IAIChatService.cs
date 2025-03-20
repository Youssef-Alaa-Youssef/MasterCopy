using Factory.DAL.Models.AI;

namespace Factory.PL.Services.AI
{
    public interface IAIChatService
    {
        Task<ChatResponse> GetResponseAsync(string message);
    }
}
