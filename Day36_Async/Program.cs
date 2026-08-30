using System.Diagnostics;

static void OrderDelivery()
{
    Console.WriteLine("Ordering delivery");
}
static async Task WaitForDelivery()
{
    Console.WriteLine("Waiting...");
    await Task.Delay(5000);
    Console.WriteLine("Delivery arrived");
}
static async Task Eat()
{
    Console.WriteLine("Eating...");
    await Task.Delay(5000);
    Console.WriteLine("Finished eating");
}
static async Task LearningCSharp()
{
    Console.WriteLine("Learning...");
    await Task.Delay(10000);
    Console.WriteLine("Finished learning C#");
}
static async Task Main()
{
    var sw = Stopwatch.StartNew();
    OrderDelivery();
    var waitingTask =  WaitForDelivery();
    var learningTask = LearningCSharp();
    await waitingTask;
    await Eat();
    await learningTask;
    sw.Stop();
    Console.WriteLine(sw.Elapsed.TotalSeconds);
}