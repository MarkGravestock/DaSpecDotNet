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
                .NameEndsWith("Test");

            Methods
                .Where(method => method.IsVoid());
        }
    }
}
