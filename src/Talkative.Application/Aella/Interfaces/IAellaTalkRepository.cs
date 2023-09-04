using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Messages;
using Talkative.Domain.Talks;

namespace Talkative.Application.Aella.Interfaces;

    public interface IAellaTalkRepository
    {
         void Add(AellaTalk aellaTalk);
    }
