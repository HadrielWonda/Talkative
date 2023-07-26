using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Domain.Messages;

    public class Message
    {
        public string TextContent {get; }
        
         public Guid TalkId {get; }

        public Guid CreatedBy{get; }

        public DateTimeOffset CreatedDateTime { get; }

        public Message(Guid talkId, string texContent, Guid createdBy, DateTimeOffset createdDateTime)
        {
            (TalkId, TextContent, CreatedBy, CreatedDateTime ) = (Guid.NewGuid(), texContent, createdBy,createdDateTime);
        }
    }
    
