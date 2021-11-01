namespace CSharp10Features.RequiredProperties;

public class Person   
{
    // public Person()
    // {
    // }
    //
    // public Perso n(string name, string firstName, string address)
    // {
    //     this.FirstName = firstName;
    //     this.Address = address;
    //     this.Name = name;
    // }
    
    public string Name { get; set; }
    public string FirstName { get; set; }
    public required string Address { get; set; }
}

public class Initializer
{
    public void Init()
    {
        var goodOldTimes = new Person("Biegota", "Mark", "Witten");
        var nowadays = new Person
        {
            Name = "Christian",
            FirstName = "Bernds",
            //Address = "Essen"
        };
    }
}