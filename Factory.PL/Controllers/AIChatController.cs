using Factory.DAL.Models.AI;
using Factory.PL.Services.AI;
using Microsoft.AspNetCore.Mvc;

namespace Factory.PL.Controllers
{
    public class AIChatController : Controller
    {
        private readonly IAIChatService _chatService;

        public AIChatController(IAIChatService chatService)
        {
            _chatService = chatService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromBody] ChatRequest request)
        {
            if (string.IsNullOrEmpty(request.Message))
            {
                return BadRequest(new ChatResponse
                {
                    Message = "Message cannot be empty",
                    IsError = true
                });
            }

            await Task.Delay(500);

            var response = await _chatService.GetResponseAsync(request.Message);
            return Json(response);
        }
    }
}
