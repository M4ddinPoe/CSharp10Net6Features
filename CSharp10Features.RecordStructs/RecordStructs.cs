namespace CSharp10Features.RecordStructs;

public struct Rectangle
{
    public int Height { get; init; }

    public int Width { get; init; }
}

// Records können nun auch als record class definiert werden
public record class Person(string FirstName, string LastName);

// Neu in C# 10 sind record structs. Diese sind nicht immutable, können aber mit
// readonly markiert werden damit sie immutable werden.
public readonly record struct Client(string FirstName, string LastName);

public class Example
{
    public void Show()
    {
        var person = new Person("Martin", "P");
        var client = new Client("Max", "Muster");
    }
}
