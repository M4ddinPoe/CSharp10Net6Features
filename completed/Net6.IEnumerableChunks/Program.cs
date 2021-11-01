int chunkNumber = 1;
foreach (int[] chunk in Enumerable.Range(0, 9).Chunk(3))
{
    Console.WriteLine($"Chunk {chunkNumber++}");
    foreach (var item in chunk)
    {
        Console.WriteLine(item);
    }
}

