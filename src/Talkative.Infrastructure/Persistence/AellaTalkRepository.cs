using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Application.Aella.Interfaces;
using Talkative.Domain.Talks;

namespace Talkative.Infrastructure.Persistence;

    public class AellaTalkRepository : IAellaTalkRepository
    {
        private static readonly Dictionary<AellaTalkId,AellaTalk> _repository = new();

        public void Add(AellaTalk talk)
        {
            _repository[talk.Id] = talk;
        }

    public bool Exists(AellaTalkId aellaTalkId)
    {
      return _repository.ContainsKey(aellaTalkId);
    }
}
