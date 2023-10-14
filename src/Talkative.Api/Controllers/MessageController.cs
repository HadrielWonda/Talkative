using Microsoft.AspNetCore.Mvc;

using Talkative.Application.Messages.Services;
using Talkative.Contracts.Messages;
using Talkative.Domain.Common.Interfaces;


namespace Talkative.Api.Controllers;

[ApiController]
    [Route("api/beta/talks/{talkId}/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IMessagesService _messagesService;

    public MessageController(IMessagesService messagesService)
    {
        _messagesService = messagesService;
    }

      [HttpPost]
        public IActionResult CreateMessage(CreateMessageRequest createMessageRequest,Guid talkId , IDateTimeProvider createdDateTime) 
        {
            var message = _messagesService.CreateMessage(talkId,createMessageRequest.TextContent,createMessageRequest.CreatedBy,createdDateTime);

            return Ok(message);
        }

         [HttpGet]
        public IActionResult ListMessages(Guid talkId) 
        {
            var message = _messagesService.ListMessages(talkId);

            return Ok(message);
        }
        
    }
