using System;
using System.Collections.Generic;
using System.Linq;
using Fixie;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DaSpec
{
    public class StepArgumentSource : ParameterSource
    {
        private ICandidateStepSource candidateStepSource;

        public StepArgumentSource(ICandidateStepSource candidateStepSource)
        {
            this.candidateStepSource = candidateStepSource;
        }

        public IEnumerable<object[]> GetParameters(MethodInfo method)
        {
            string regularExpression = method.GetCustomAttributes<StepDefinitionAttribute>(true).Select(attribute => attribute.RegularExpression).First();

            StepArgumentMatcher stepArgumentMatcher = new StepArgumentMatcher(regularExpression, candidateStepSource);
            return stepArgumentMatcher.FindStepArguments();
        }
    }
}
