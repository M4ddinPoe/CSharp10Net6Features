PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
queue.Enqueue("Item A", 0);
queue.Enqueue("Item B", 60);
queue.Enqueue("Item C", 2);
queue.Enqueue("Item D", 1);

while (queue.TryDequeue(out string item, out int priority))
{
    Console.WriteLine($"Popped Item : {item}. Priority Was : {priority}");
}