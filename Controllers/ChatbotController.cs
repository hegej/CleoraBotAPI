using CleoraChatbot;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class ChatBotController : ControllerBase
{
    private readonly ChatBot _chatBot;
    private readonly Session _session;

    public ChatBotController(ChatBot chatBot, Session session)
    {
        _chatBot = chatBot;
        _session = session;
    }

    [HttpGet]
    public string GetChatResponse(string userPrompt)
    {
        
        return _chatBot.GetChatResponse(userPrompt, _session);
    }
}
