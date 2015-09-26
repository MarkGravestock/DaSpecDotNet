using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaSpec
{
    class EmptyCandidateStepSource : ICandidateStepSource
    {
        public IEnumerable<string> GetCandidateSteps()
        {
            yield break;
        }
    }
}
