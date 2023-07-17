using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Domain.Talks;

    public public class Talk
    {
        public Guid Id {get; }

        public Guid CreatedBy{get; }

        public Guid SecondParty{get; }

        public Talk(Guid createdBy,Guid secondParty)
        => (CreatedBy,SecondParty,Id) = (createdBy,secondParty,Guid.NewGuid());
    }
    
        
    
    


