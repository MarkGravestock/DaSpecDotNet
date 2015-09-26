using Should.Fluent;
using DaSpec.Example.Implementation;

namespace DaSpec.Example.Steps
{
    public class HelloWorldSteps
    {
        [StepDefinition("The right way to greet the (.*) is \"(.*)\"")]
        public void Greeting(string subject, string expectedGreeting)
        {
            var sut = new Greeter();

            var actualGreeting = sut.GreetingFor(subject);

            actualGreeting.Should().Equal(expectedGreeting);
        }
    }
}
