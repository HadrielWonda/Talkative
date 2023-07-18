using Talkative.Application.Talks.Interfaces;
using Talkative.Domain.Talks;

namespace Talkative.Infrastructure.Persistence;

public class TalksRepository : ITalksRepository
    {
    private static readonly Dictionary<Guid,Talk> _repository = new();
    public void Add(Talk talk)
    {
        _repository[talk.Id] = talk;
    }


}
