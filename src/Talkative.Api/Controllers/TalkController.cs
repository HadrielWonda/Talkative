using Microsoft.AspNetCore.Mvc;

using Talkative.Application.Talks.Services;
using Talkative.Contracts.Talks;

namespace Talkative.Api.Controllers;

[ApiController]
    [Route("api/beta/[controller]")]
    public class TalkController : ControllerBase
    {
        private readonly ITalksService _talksService;


    public TalkController(ITalksService talksService)
    {
        
        _talksService = talksService;  
    }

      [HttpPost]
        public IActionResult CreateTalk(CreateTalkRequest createTalkRequest, DateTimeOffset createdDateTime ) 
        {
            var talk = _talksService.CreateTalk(createTalkRequest.CreatedBy,createTalkRequest.SecondParty,createdDateTime);

            return Ok(talk);
        }
        
    }
