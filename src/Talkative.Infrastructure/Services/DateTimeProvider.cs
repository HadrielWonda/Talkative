using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Talkative.Domain.Common.Interfaces;

namespace Talkative.Infrastructure.Services;

    public class DateTimeProvider : IDateTimeProvider
    {
       public DateTimeOffset UtcNow() => DateTimeOffset.Now;
    }
        
    
