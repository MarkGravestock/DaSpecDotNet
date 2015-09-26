using System;
using System.Collections.Generic;
using System.Linq;
using Should.Fluent;
using System.Text;
using System.Threading.Tasks;

namespace DaSpec.Test
{
    public class FileSystemMarkdownCandidateStepSourceTest
    {
        private FileSystemMarkdownCandidateStepSource sut = new FileSystemMarkdownCandidateStepSource(".");

        public void CanFindRightNumberOfSteps()
        {
            sut.GetCandidateSteps().Count().Should().Equal(1);
        }
    }
}
