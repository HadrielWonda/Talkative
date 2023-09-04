using Talkative.Domain.Messages;

namespace Talkative.Application.Messages.Services;

public interface IMessagesService
    {
        Message CreateMessage(Guid talkId, string textContent, Guid createdBy,DateTimeOffset createdDateTime);
        IList<Message> ListMessages(Guid talkId);
}
