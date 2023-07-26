using Microsoft.AspNetCore.Mvc;

using Talkative.Application.Messages.Services;
using Talkative.Contracts.Messages;

namespace Talkative.Api.Controllers;

[ApiController]
    [Route("api/talks/{talkId}/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessagesService _messagesService;

    public MessageController(IMessagesService messagesService)
    {
        _messagesService = messagesService;
    }

      [HttpPost]
        public IActionResult CreateMessage(CreateMessageRequest createMessageRequest,Guid talkId ) 
        {
            var talk = _messagesService.CreateMessage(talkId,createMessageRequest.TextContent,createMessageRequest.CreatedBy);

            return Ok(talk);
        }
        
    }
