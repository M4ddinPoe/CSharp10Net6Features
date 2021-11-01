namespace CSharp10Features
{
    using System.Text.Json;

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

