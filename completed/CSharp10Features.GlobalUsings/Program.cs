using System.Text.Json;
    
var names = new { Host="Mark", Speaker="Martin", Research="Christian" };
var serialized = JsonSerializer.Serialize(names);

Console.WriteLine(serialized);
