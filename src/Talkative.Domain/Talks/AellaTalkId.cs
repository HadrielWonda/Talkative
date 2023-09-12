using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Domain.Talks;

    public class AellaTalkId
    {
        
        public string Value { get; }

    
        public AellaTalkId(string value)
         {
           Value = value;
         }

        public static AellaTalkId CreateForTalkId(Guid talkId)
         => new($"aella.{talkId}");

    public static implicit operator AellaTalkId(Guid v)
    {
        throw new NotImplementedException();
    }
}
