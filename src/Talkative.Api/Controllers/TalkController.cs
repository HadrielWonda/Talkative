using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Talkative.Contracts.Talks;

namespace Talkative.Api.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        [HttpPost("/talks")]
        public IActionResult CreateTalk(CreateTalkRequest createTalkRequest) 
        {
            
        }
        
    }
