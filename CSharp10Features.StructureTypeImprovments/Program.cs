// See https://aka.ms/new-console-template for more information
using CSharp10Features.StructureTypeImprovments;

Console.WriteLine("Hello, World!");

var rectangle = new Rectangle(100, 100);

var rectangle2 = rectangle with { Width = 20 };
