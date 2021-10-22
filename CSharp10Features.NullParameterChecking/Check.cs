using System;

namespace CSharp10Features.NullParameterChecking;

public class Check
{
    public bool DoCheck(string text)
    {
        ArgumentNullException.ThrowIfNull(text);

        return text == "Test";
    }
}