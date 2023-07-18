using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talkative.Domain.Talks;

namespace Talkative.Application.Talks.Interfaces;

    public interface ITalksRepository
    {
        void Add(Talk talk);
    }
