using System.Collections.Generic;

namespace DaSpec
{
    public interface ICandidateStepSource
    {
        IEnumerable<string> GetCandidateSteps();
    }
}