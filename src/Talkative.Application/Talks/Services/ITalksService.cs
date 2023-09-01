using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Talks;

namespace Talkative.Application.Talks.Services;

    public interface ITalksService
    {
        Talk CreateTalk(Guid createdBy, Guid secondParty,DateTimeOffset dateTimeOffset);
    }
