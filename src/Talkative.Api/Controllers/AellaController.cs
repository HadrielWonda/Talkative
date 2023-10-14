using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Talkative.Application.Aella.Services;
using Talkative.Contracts.Aella;

namespace Talkative.Api.Controllers
{
    [ApiController]
    [Route("/api/beta/talks/{talkId}/aella")]
    public class AellaController : ControllerBase
    {
        private readonly IAellaService _aellaService;

        public AellaController(IAellaService aellaService)
        {
            _aellaService = aellaService;
        }

        [HttpPost("messages")]
        public IActionResult AnswerPrompt(AnswerPromptRequest answerPromptRequest,Guid talkId)
        {
          // throw new NotImplementedException();
         var response = _aellaService.AnswerPrompt(talkId,
                     answerPromptRequest.TextContent,
                     answerPromptRequest.CreatedBy);

          return Ok(response) ;          
        }
    }
}