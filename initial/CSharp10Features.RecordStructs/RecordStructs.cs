namespace CSharp10Features.RecordStructs;

public record Person(string FirstName, string LastName);

public struct Rectangle 
{
    public int Height { get; init; }

    public int Width { get; init; }
}