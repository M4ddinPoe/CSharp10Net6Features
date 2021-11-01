using System;

namespace CSharp10Features.RecordTypesSealToString;

public record Person(string FirstName, string LastName)
{
    public override string ToString()
    {
        return $"Hi my name is: {FirstName} {LastName}";
    }

    public virtual string ToXml()
    {
        return $"<FirstName>{FirstName}</FirstName><LastName>{LastName}</LastName>";
    }
}

public record Client(string FirstName, string LastName, string EMail) 
    : Person(FirstName, LastName)
{
    public override string ToString()
    {
        return $"Hi my name is: {FirstName} {LastName}. And my E-Mail is: {EMail}";
    }
}

