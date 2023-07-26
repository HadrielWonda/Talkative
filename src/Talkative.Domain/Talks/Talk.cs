using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using Talkative.Domain.Common.Interfaces;

namespace Talkative.Domain.Talks;

    public class Talk{
    
        public Guid Id {get; }

        public Guid CreatedBy{get; }

        public Guid SecondParty{get; }

        public DateTimeOffset CreatedDateTime { get; }

        public Talk(
         Guid createdBy,
         Guid secondParty,
         IDateTimeProvider dateTimeProvider,
         Guid? id = null)
        {
            Id = id ?? Guid.NewGuid();
            CreatedBy = createdBy;
            SecondParty = secondParty;
            CreatedDateTime = dateTimeProvider.UtcNow();
        }

    public Talk(Guid createdBy, Guid secondParty, DateTimeOffset createdDateTime)
    {
        CreatedBy = createdBy;
        SecondParty = secondParty;
        CreatedDateTime = createdDateTime;
    }
    // => (CreatedBy,SecondParty,CreatedDateTime,Id) = (createdBy,secondParty,createdDateTime,Guid.NewGuid());

}
