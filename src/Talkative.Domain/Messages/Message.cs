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

        private Message(Guid talkId, 
                        string textContent,
                        Guid createdBy, 
                        DateTimeOffset createdDateTime)
        {
            (TalkId, TextContent, CreatedBy, CreatedDateTime ) = (talkId, textContent, createdBy,createdDateTime);
        }

        public static Message Create(string textContent,
                                     Guid createdBy,
                                     DateTimeProvider dateTimeProvider/*,
                                     Guid? talkId = null*/)
        {
          return new(
            Guid.NewGuid(),
            textContent,
            createdBy,
            dateTimeProvider.UtcNow(),
          );
        }
    }
    
