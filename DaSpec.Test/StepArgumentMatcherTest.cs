using System;
using System.Collections.Generic;
using System.Linq;
using Should.Fluent;
using System.Text;
using System.Threading.Tasks;

namespace DaSpec.Test
{
    public class StepArgumentMatcherTest
    {
        private StepArgumentMatcher sut = new StepArgumentMatcher("The right way to greet the (.*) is \"(.*)\"", new FakeCandidateStepSource());

        public void CanMatchRightNumberOfSteps()
        {
            sut.FindStepArguments().Count().Should().Equal(2);
        }

        public void CanReturnCorrectNumberOfArguments()
        {
            sut.FindStepArguments().First().Count().Should().Equal(2);
        }

        public void CanReturnCorrectArgument()
        {
            sut.FindStepArguments().First().First().Should().Equal("World");
        }

        public class FakeCandidateStepSource : ICandidateStepSource
        {
            string candidateSteps = "# This is a heading so it's ignored\n\n" +
                                    "> this is a block quote so it's ignored as well\n" +
                                    "> but the line below is normal text so it will be executed\n" +
                                    "The right way to greet the World is \"Hello, World!\"\n" +
                                    "The right way to greet the Universe is \"Hello, Galaxy!\"";

            public IEnumerable<string> GetCandidateSteps()
            {
                yield return candidateSteps;
            }
        }
    }
}
