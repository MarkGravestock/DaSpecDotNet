using System.Collections.Generic;
using Fixie;
using System.Reflection;
using System.Linq;

namespace DaSpec
{
    public class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes
                .NameEndsWith("Steps");
            //  .Where(HasAnyStepDefinitionMethods);

            Methods
                .HasOrInherits<StepDefinitionAttribute>();

            Parameters
                .Add(new StepArgumentSource(new FileSystemMarkdownCandidateStepSource(".\\Specs")));
        }
    }
}
