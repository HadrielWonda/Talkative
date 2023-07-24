using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Messages;

namespace Talkative.Application.Messages.Interfaces;

    public interface IMessagesRepository
    {
        void Add(Guid talkId,Message message);
    }
