using Net6.ByMethods;

var people = GetPeople();

//var oldestAge = people.Max(person => person.Age);
//var youngestAge = people.Min(person => person.Age);

//var oldest = people.FirstOrDefault(p => p.Age == oldestAge);
//var youngest = people.FirstOrDefault(p => p.Age == youngestAge);

var oldest = people.MaxBy(p => p.Age);
var youngest = people.MinBy(p => p.Age);

Console.WriteLine($"The oldest person is {oldest.Age}");
Console.WriteLine($"The youngest person is {youngest.Age}");

IEnumerable<Person> GetPeople() => new List<Person>
           {
    new Person("Max", 28),
    new Person("Lea", 19),
    new Person("Tom", 42),
    new Person("Isa", 36)
           };
