var names = new List<string> { "Max", "Lea", "Tom", "Isa" };
string name = names.FirstOrDefault(name => name == "Maddin", "- na -");

Console.WriteLine(name);

