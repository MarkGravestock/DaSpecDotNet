using System;
using Fixie.Execution;

namespace Example
{
    internal class DaSpecListener : LongLivedMarshalByRefObject, Listener 
    {
        public void AssemblyCompleted(AssemblyInfo assembly, AssemblyResult result)
        {
            
        }

        public void AssemblyStarted(AssemblyInfo assembly)
        {
            
        }

        public void CaseFailed(FailResult result)
        {
            
        }

        public void CasePassed(PassResult result)
        {
            
        }

        public void CaseSkipped(SkipResult result)
        {
            
        }
    }
}