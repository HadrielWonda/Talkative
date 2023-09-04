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
    [Route("/api/beta/talks/{talkId}/aella/answers")]
    public class AellaController : ControllerBase
    {
        private readonly IAellaService _aellaService;

        public AellaController(IAellaService aellaService)
        {
            _aellaService = aellaService;
        }

        public IActionResult AnswerPrompt(AnswerPromptRequest answerPromptRequest)
        {
           throw new NotImplementedException();
        }
    }
}