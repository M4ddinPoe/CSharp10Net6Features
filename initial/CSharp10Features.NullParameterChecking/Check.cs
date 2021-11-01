using System;

namespace CSharp10Features.NullParameterChecking;

public class Check
{
    public bool DoCheck(string text)
    {
        if (text == null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        return text == "Test";
    }
}