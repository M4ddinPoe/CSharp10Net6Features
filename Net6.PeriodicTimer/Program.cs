// See https://aka.ms/new-console-template for more information

var timer = new PeriodicTimer(TimeSpan.FromSeconds(1));

while (await timer.WaitForNextTickAsync())
{
    Console.WriteLine(DateTime.UtcNow);
}

