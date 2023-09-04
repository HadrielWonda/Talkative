using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Talkative.Contracts.Aella;

    public record AnswerPromptRequest( string TextContent, Guid CreatedBy);
       
