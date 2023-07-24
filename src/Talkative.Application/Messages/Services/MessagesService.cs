using Talkative.Domain.Messages;
using Talkative.Application.Messages.Interfaces;

namespace Talkative.Application.Messages.Services;

public class MessagesService : IMessagesService
    {
         private readonly IMessagesRepository _messagesRepository;

        public MessagesService(IMessagesRepository messagesRepository)
        {
           _messagesRepository = messagesRepository;
        }

        public Message CreateMessage(Guid talkId,string textContent,Guid CreatedBy, Guid SecondParty)
        {
            var message = new Message(talkId,textContent,CreatedBy,SecondParty);

            _messagesRepository.Add(talkId,message);

            return message;
        }
    }
