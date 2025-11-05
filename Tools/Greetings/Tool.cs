using System.ComponentModel;
using Optimizely.Opal.Tools;

namespace OpalDemoTool.Tools.Greetings;

public class GreetingsTool
{
    [OpalTool(name: "Greeting")]
    [Description("Greets a person")]
    public object Greet(GreetingsParameters inputVars)
    {
        string greeting = "Hi " + inputVars.Name;

        return new
        {
            greeting
        };
    }
}