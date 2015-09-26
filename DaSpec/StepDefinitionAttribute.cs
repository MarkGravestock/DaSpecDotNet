using System;

namespace DaSpec
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class StepDefinitionAttribute : Attribute
    {
        public StepDefinitionAttribute(string regularExpression)
        {
            RegularExpression = regularExpression;
        }

        public string RegularExpression { get; private set; }
    }
}
