using System.Diagnostics;

Console.WriteLine("\n========== ASYNC / AWAIT ==========\n");

Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");

void SendMessage(string message)
{
    Console.WriteLine("Sending message ...");
    Thread.Sleep(3000);
    Console.WriteLine($"Message {message} sent!");
    Console.WriteLine($"Current Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");
}

async Task SendMessageAsync(string message)
{
    Console.WriteLine($"Current Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");
    Console.WriteLine("Sending message ...");
    await Task.Delay(3000);
    Console.WriteLine($"Current Thread Id: {Thread.CurrentThread.ManagedThreadId}\n");
    Console.WriteLine($"Message {message} sent!");
}

void ShowAd()
{
    Console.WriteLine("While you wait, here's and add. Buy the 'Iphone 17' for special price");
}

Stopwatch stopwatch = new Stopwatch();

Console.WriteLine("========== Synchrouns Execution ==========");

stopwatch.Restart();

SendMessage("Hello Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds}ms");


Console.WriteLine("========== Async WITHOUT await - Fire and Forget ==========");

stopwatch.Restart();

SendMessageAsync("Hello Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds}ms");

Console.WriteLine("========== Async WITH await - Fire and Forget ==========");

stopwatch.Restart();
await SendMessageAsync("Hello Avenga Academy!");
ShowAd();
stopwatch.Stop();
Console.WriteLine($"Total time {stopwatch.ElapsedMilliseconds}ms");


Console.ReadLine();