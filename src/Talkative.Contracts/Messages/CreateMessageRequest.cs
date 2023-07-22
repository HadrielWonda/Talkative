namespace Talkative.Contracts.Messages;

public record CreateMessageRequest(string TextContent , Guid CreatedBy, Guid SecondParty);
