using Net6.ByMethods;


var people = new List<Person>
{
    new ("Max", 28),
    new ("Lea", 19),
    new ("Tom", 42),
    new ("Isa", 42)
};

var oldest = people.MaxBy(person => person.Age);
var youngest = people.MinBy(person => person.Age);

Console.WriteLine($"The oldest person is {oldest.Name}");
Console.WriteLine($"The youngest person is {youngest.Name}");
