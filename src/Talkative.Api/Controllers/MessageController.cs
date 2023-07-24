using Microsoft.AspNetCore.Mvc;

using Talkative.Application.Messages.Services;
using Talkative.Contracts.Messages;

namespace Talkative.Api.Controllers;

[ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessagesService _messagesService;

    public MessageController(IMessagesService messagesService)
    {
        _messagesService = messagesService;
    }

      [HttpPost]
        public IActionResult CreateMessage(CreateMessageRequest createMessageRequest) 
        {
            var message = _messagesService.CreateMessage(createMessageRequest.TextContent,createMessageRequest.CreatedBy,createMessageRequest.SecondParty);

            return Ok(message);
        }
        
    }
