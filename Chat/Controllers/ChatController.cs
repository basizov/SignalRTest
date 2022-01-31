using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    private readonly ILogger<ChatController> _logger;

	public ChatController(ILogger<ChatController> logger) => _logger = logger;

	[HttpPost]
    public async Task<ActionResult<string>> PostAsync()
	{
		_logger.LogInformation("Connection to the chat");
		return await Task.FromResult(Ok("Connected to the chat!"));
	}
}
