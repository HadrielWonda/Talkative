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
        
         public Guid Id {get; }

        public Guid CreatedBy{get; }

        public Guid SecondParty{get; }

        public Message(string texContent,Guid createdBy,Guid secondParty)
        => (TextContent,CreatedBy,SecondParty,Id) = (texContent,createdBy,secondParty,Guid.NewGuid());
    }
    
}