using Talkative.Domain.Messages;

namespace Talkative.Application.Messages.Services;

public interface IMessagesService
    {
        Message CreateMessage(Guid talkId, string textContnt, Guid createdBy, Guid secondParty);
    }
