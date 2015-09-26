using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace DaSpec
{
    public class StepArgumentMatcher
    {
        private string regularExpression;
        private ICandidateStepSource candidateStepSource;

        public StepArgumentMatcher(string regularExpression, ICandidateStepSource candidateStepSource)
        {
            this.candidateStepSource = candidateStepSource;
            this.regularExpression = regularExpression;
        }

        public IEnumerable<object[]> FindStepArguments()
        {
            foreach (string candidateSteps in candidateStepSource.GetCandidateSteps())
            {
                foreach (Match matchedStep in Regex.Matches(candidateSteps, regularExpression))
                {
                    yield return matchedStep.Groups.Cast<Group>().ToList().Skip(1).Select(x => x.Value).ToArray();
                }
            }
        }
    }
}