using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Talkative.Domain.Common.Interfaces;

namespace Talkative.Domain.Messages;

    public class Message
    {
        public Message(string textContent, Guid talkId, Guid createdBy, DateTimeOffset createdDateTime) 
        {
            this.TextContent = textContent;
    this.TalkId = talkId;
    this.CreatedBy = createdBy;
    this.CreatedDateTime = createdDateTime;
   
        }
     
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
                                     IDateTimeProvider dateTimeprovider/*,
                                     Guid? talkId = null*/)
        {
          return new(
            Guid.NewGuid(),
            textContent,
            createdBy,
            dateTimeprovider.UtcNow()
          );
        }
    }
    
