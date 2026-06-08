Console.WriteLine("\n========== TASKS ==========\n");

Console.WriteLine("===== Task Status Lifecycle =====");

//Task myTask = new Task(() => { });

Task myTask = Task.Run(() =>
{
    Thread.Sleep(2000);
    Console.WriteLine("Running after 2000ms");
});

Console.WriteLine($"Right after start: {myTask.Status}");
Thread.Sleep(500);
Console.WriteLine($"While running: {myTask.Status}");
myTask.Wait();
Console.WriteLine($"After completion: {myTask.Status}");


Console.WriteLine("===== Task<T> - Returning a Value =====");

Task<int> valueTask = Task.Run(() =>
{
    Thread.Sleep(1500);
    return 300;
});

Console.WriteLine(valueTask.Result);
Console.WriteLine("Status after .Result " + valueTask.Status);


Console.WriteLine("===== 20 Tasks =====");

Random rnd = new Random();
for (int i = 1; i <= 20; i++)
{
    int temp = i;
    Task.Run(() =>
    {
        int delay = rnd.Next(500, 2000);
        Thread.Sleep(delay);
        Console.WriteLine($"Task {temp} done after {delay} ms. [Thread ID: {Thread.CurrentThread.ManagedThreadId}]");
    });
}



Console.ReadLine();