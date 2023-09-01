using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Talks;
using Talkative.Application.Talks.Interfaces;
using Talkative.Domain.Common.Interfaces;

namespace Talkative.Application.Talks.Services;

    public class TalksService : ITalksService
    {

        private readonly ITalksRepository _talksRepository;
        private readonly IDateTimeProvider _dateTimeProvider;

    public TalksService(ITalksRepository talksRepository, IDateTimeProvider dateTimeProvider)
    {
        _talksRepository = talksRepository;
        _dateTimeProvider = dateTimeProvider;
    }

    public Talk CreateTalk(Guid createdBy, Guid secondParty, DateTimeOffset dateTimeOffset)
        {
            var talk = Talk.Create(Guid.NewGuid(),createdBy,_dateTimeProvider,secondParty );

            _talksRepository.Add(talk);

            return talk;
        }
    }
