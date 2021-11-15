namespace CSharp10Features.AttributesSupportGenerics;

// Vor C# 10 könnte man mit Typen nur arbeiten wenn diese im Konstruktor übergeben wurden
public class OldAttribute : Attribute
{
    public OldAttribute(Type type)
    {

    }
}

// C# 10 erlaubt generische Attribute
public class NewAttribute<T> : Attribute
{
    public T My { get; set; }
}