int chunkNumber = 1;

var longEnumerable = Enumerable.Range(0, 7);

foreach (int[] chunk in longEnumerable.Chunk(3))
{
    Console.WriteLine($"Chunk {chunkNumber++}");
    foreach (var item in chunk)
    {
        Console.WriteLine(item);
    }
}

