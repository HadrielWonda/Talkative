using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Common.Interfaces;

namespace Talkative.Domain.Talks;

    public class AellaTalk
    {
    
        public Guid Id {get; }

        public Guid TalkId {get; }

        public DateTimeOffset CreatedDateTime { get; }

        private AellaTalk(
         Guid talkId,
         DateTimeOffset dateTimeOffset,
         Guid id)
        {
            Id = id;
            TalkId = talkId;
            CreatedDateTime = dateTimeOffset;
        }

    public AellaTalk(Guid guid, Guid talkId, DateTimeOffset dateTimeOffset)
    {
        //CreatedBy = createdBy;
        TalkId = talkId;
        
    }

    public static AellaTalk Create(Guid talkId,
              IDateTimeProvider dateTimeProvider)
              {
                return new(Guid.NewGuid(),
                  talkId,
                  dateTimeProvider.UtcNow());
              }
 }
