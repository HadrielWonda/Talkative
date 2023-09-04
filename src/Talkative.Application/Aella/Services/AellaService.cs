using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Application.Messages.Interfaces;
using Talkative.Application.Messages.Services;
using Talkative.Application.Talks.Interfaces;
using Talkative.Application.Talks.Services;
using Talkative.Domain.Common.Interfaces;
using Talkative.Domain.Talks;

namespace Talkative.Application.Aella.Services;

    public class AellaService :IAellaService
    {
       private readonly IMessagesService _messagesService;
       private readonly IDateTimeProvider _dateTimeProvider;
    // private readonly ITalksService _talksService;

    public AellaService(IMessagesService messagesService /*ITalksService talksService*/, IDateTimeProvider dateTimeProvider)
    {
        _messagesService = messagesService;
        _dateTimeProvider = dateTimeProvider;
        // _talksService = talksService;
    }

    public string AnswerPrompt(Guid talkId,string TextContent,Guid CreatedBy)
        {
           var aellaTalk = AellaTalk.Create(talkId,_dateTimeProvider);
            return "Hi I'm Aella, pleased to meet you";
        }
    }
