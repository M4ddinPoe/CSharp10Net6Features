var names = new List<string> { "Max", "Lea", "Tom", "Isa" };
string longName = names.FirstOrDefault(name => name.Length > 3) ?? "- na -";

Console.WriteLine(longName);

