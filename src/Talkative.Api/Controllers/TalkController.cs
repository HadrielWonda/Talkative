using Microsoft.AspNetCore.Mvc;

using Talkative.Application.Talks.Services;
using Talkative.Contracts.Talks;

namespace Talkative.Api.Controllers;

[ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly ITalksService _talksService;

    public ChatController(ITalksService talksService)
    {
        _talksService = talksService;
    }

      [HttpPost]
        public IActionResult CreateTalk(CreateTalkRequest createTalkRequest) 
        {
            var talk = _talksService.CreateTalk(createTalkRequest.createdBy,createTalkRequest.secondParty);

            return Ok();
        }
        
    }
