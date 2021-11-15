namespace CSharp10Features
{
    // using System wird in der GlobalUsings Datei referenziert
    // using System.Text.Json wird direkt in der Projekt Datei referenziert

    internal class Program
    {
        public static void Main(string[] args)
        {
            var names = new { Host = "Mark", Speaker = "Martin", Research = "Christian" };
            var serialized = JsonSerializer.Serialize(names);

            Console.WriteLine(serialized);
        }
    }
}

