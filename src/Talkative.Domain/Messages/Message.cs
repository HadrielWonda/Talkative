using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Domain.Messages
{
    public class Message
    {
         public Guid Id {get; }

        public Guid CreatedBy{get; }

        public Guid SecondParty{get; }

        public Message(Guid createdBy,Guid secondParty)
        => (CreatedBy,SecondParty,Id) = (createdBy,secondParty,Guid.NewGuid());
    }
    
}