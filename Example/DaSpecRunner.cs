using Fixie.Execution;
using Fixie;

namespace Example
{
    public class DaSpecRunner
    {
        public static void Main()
        {
            using (var listener = new DaSpecListener())
            {
                using (var environment = new ExecutionEnvironment("."))
                {
                    environment.RunAssembly(new Options(), listener);
                }
            }
        }
    }
}
