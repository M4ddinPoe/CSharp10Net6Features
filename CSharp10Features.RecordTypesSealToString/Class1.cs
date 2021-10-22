using System;

namespace CSharp10Features.RecordTypesSealToString;

public record Person(string FirstName, string LastName)
{
    public sealed override string ToString()
    {
        return $"Hi my name is: {FirstName} {LastName}";
    }

    public virtual string ToFullName()
    {
        return string.Empty;
    }
}

public record Client(string FirstName, string LastName, string EMail) 
    : Person(FirstName, LastName)
{
    public override string ToString()
    {
        return $"Hi my name is: {FirstName} {LastName}";
    }

    public sealed override string ToFullName()
    {
        return base.ToString();
    }
}

public record Customer(string FirstName, string LastName, string EMail) : Client(FirstName, LastName, EMail)
{
    public override string ToFullName()
    {
        return $"Hello, I'am {FirstName} {LastName} and you can reach me through: {EMail}";
    }
}