namespace CSharp10Features.NullParameterChecking;

public class Check
{
    public bool DoCheck(string text)
    {
        // ------ C# 9
        if (text is null)
        {
            throw new ArgumentNullException(nameof(text));
        }

        // ------ C# 10
        ArgumentNullException.ThrowIfNull(text);

        return text == "Test";
    }
}