using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talkative.Application.Talks.Interfaces;
//using Talkative.Domain.Talks.Interfaces;

namespace Talkative.Infrastructure.Persistence;

    public class TalksRepository : ITalksRepository
    {
        public void Add(Talk talk);
    }
