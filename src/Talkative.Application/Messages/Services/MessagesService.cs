using Talkative.Domain.Messages;
using Talkative.Application.Messages.Interfaces;
using Talkative.Domain.Common.Interfaces;

namespace Talkative.Application.Messages.Services;

public class MessagesService : IMessagesService
    {
         private readonly IMessagesRepository _messagesRepository;
         private readonly IDateTimeProvider _dateTimeProvider;

    public MessagesService(IMessagesRepository messagesRepository, IDateTimeProvider dateTimeProvider)
    {
        _messagesRepository = messagesRepository;
        _dateTimeProvider = dateTimeProvider;
    }

    public Message CreateMessage(Guid talkId,string textContent,Guid CreatedBy,DateTimeOffset dateTimeOffset)
        {
            var message = Message.Create(talkId,textContent,CreatedBy,_dateTimeProvider);

            _messagesRepository.Add(talkId,message);

            return message;
        }
    }
