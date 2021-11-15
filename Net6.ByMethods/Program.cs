using Net6.ByMethods;
using System;
using System.Collections.Generic;
using System.Linq;

var people = GetPeople();

var oldest = people.MaxBy(person => person.Age);
var youngest = people.MinBy(person => person.Age);

Console.WriteLine($"The oldest person is {oldest.Name}");
Console.WriteLine($"The youngest person is {youngest.Name}");

IEnumerable<Person> GetPeople() => new List<Person>
{
    new Person("Max", 28),
    new Person("Lea", 19),
    new Person("Tom", 42),
    new Person("Isa", 42)
};
