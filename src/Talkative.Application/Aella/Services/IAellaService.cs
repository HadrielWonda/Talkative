using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Messages;

namespace Talkative.Application.Aella.Services;

    public interface IAellaService
    {
        public Message AnswerPrompt(Guid talkId,string TextContent,Guid CreatedBy);
    }
