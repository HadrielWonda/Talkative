using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Application.Aella.Interfaces;
using Talkative.Application.Messages.Services;
using Talkative.Domain.Common.Interfaces;
using Talkative.Domain.Messages;
using Talkative.Domain.Talks;

namespace Talkative.Application.Aella.Services;

    public class AellaService :IAellaService
    {
       private readonly IMessagesService _messagesService;
       private readonly IDateTimeProvider _dateTimeProvider;
       private readonly IAellaTalkRepository _aellaTalkRepository;
    // private readonly ITalksService _talksService;

    public AellaService(IMessagesService messagesService /*ITalksService talksService*/, IDateTimeProvider dateTimeProvider, IAellaTalkRepository aellaTalkRepository)
    {
        _messagesService = messagesService;
        _dateTimeProvider = dateTimeProvider;
        _aellaTalkRepository = aellaTalkRepository;
        // _talksService = talksService;
    }

    public string AnswerPrompt(Guid talkId,string TextContent,Guid CreatedBy)
        {
            if (!_aellaTalkRepository.Exists(talkId))
            {
                var aellaTalk = AellaTalk.Create(talkId,_dateTimeProvider);
                _aellaTalkRepository.Add(aellaTalk);
            }

           // var message = Message.Create(talkId,TextContent,CreatedBy,_dateTimeProvider);
           _messagesService.CreateMessage(talkId,TextContent,CreatedBy,_dateTimeProvider);
           
            return "Hi I'm Aella, pleased to meet you";
        }
    }
