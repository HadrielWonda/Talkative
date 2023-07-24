using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Domain.Messages
{
    public class Message
    {
        public string TextContent {get; }
        
         public Guid TalkId {get; }

        public Guid CreatedBy{get; }

        public Guid SecondParty{get; }

        public Message(Guid talkId,string texContent,Guid createdBy,Guid secondParty)
        => (TalkId,TextContent,CreatedBy,SecondParty) = (Guid.NewGuid(),texContent,createdBy,secondParty);
    }
    
}