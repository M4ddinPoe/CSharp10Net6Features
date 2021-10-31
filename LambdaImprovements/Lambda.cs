using System;

namespace CSharp10Features.LambdaImprovements;

public class Lambda
{
    public void DoStuff()
    {
        Func<string> hello = () => "Hello!";
        var hello2 = () => "Hello!";
        var helloNull = string () => null;
    }
}