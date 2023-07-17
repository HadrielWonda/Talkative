using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Contracts.Chats;

public record CreateTalkRequest(Guid createdBy, Guid secondParty);

