using Talkative.Domain.Messages;

namespace Talkative.Application.Messages.Services;

public interface IMessagesService
    {
        Message CreateMessage(Guid createdBy, Guid secondParty);
    }
