using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Domain.Common.Interfaces;

    public interface IDateTimeProvider
    {
        DateTimeOffset UtcNow();
    }
