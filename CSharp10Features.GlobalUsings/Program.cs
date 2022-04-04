namespace CSharp10Features
{
    // using PowerArgs wird in der GlobalUsings Datei referenziert
    // using System.Text.Json wird direkt in der Projekt Datei referenziert

    internal class Program
    {
        public static void Main(string[] args)
        {
            var parsed = Args.Parse<GlobalUsingsArgs>(args);

            var names = new { Host = parsed.Host, Speaker = parsed.Speaker, Research = parsed.Researcher };
            var serialized = JsonSerializer.Serialize(names);

            Console.WriteLine(serialized);
        }
    }
}

