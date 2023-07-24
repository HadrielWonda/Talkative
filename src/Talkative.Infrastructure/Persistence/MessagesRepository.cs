using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Application.Messages.Interfaces;
using Talkative.Domain.Messages;

namespace Talkative.Infrastructure.Persistence
{
    public class MessagesRepository : IMessagesRepository
    {

        private static readonly Dictionary<Guid,List<Message>> _repository = new ();
        public void Add(Guid talkId,Message message)
        {
           //throw new NotImplementedException();
           //_repository[message.Id] = message;


           if (_repository.TryGetValue(talkId, out var messages))
           {
              messages.Add(message);
              return;
           }

           _repository[talkId] = new List<Message>{ message };
            
        }
    }
}