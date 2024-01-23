#region Semaphore
//List<int> numbers = new();
//Semaphore semaphore = new(4, 3);
//Thread thread1 = new(() =>
//{
//    semaphore.WaitOne();
//    int i = 0;
//    while (i < 10)
//    {
//        Console.WriteLine($"Thread1 {++i}");
//        numbers.Add(i);
//        Thread.Sleep(1000);
//    }
//    semaphore.Release();
//});
//Thread thread2 = new(() =>
//{
//    semaphore.WaitOne();
//    int i = 10;
//    while (i < 20)
//    {
//        Console.WriteLine($"Thread2 {++i}");
//        numbers.Add(i);
//        Thread.Sleep(1500);
//    }
//    semaphore.Release();
//});
//Thread thread3 = new(() =>
//{
//    semaphore.WaitOne();
//    int i = 20;
//    while (i < 30)
//    {
//        Console.WriteLine($"Thread3 {++i}");
//        numbers.Add(i);
//        Thread.Sleep(2000);
//    }
//    semaphore.Release();
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion
#region SemaphoreSlim
List<int> numbers = new();
using SemaphoreSlim semaphoreSlim = new(3, 3);
Thread thread1 = new(() =>
{
    semaphoreSlim.Wait(100);
    int i = 0;
    while (i < 10)
    {
        Console.WriteLine($"Thread1 {++i}");
        numbers.Add(i);
        Thread.Sleep(100);
    }
    semaphoreSlim.Release();
});
Thread thread2 = new(() =>
{
    semaphoreSlim.Wait(1000);
    int i = 10;
    while (i < 20)
    {
        Console.WriteLine($"Thread2 {++i}");
        numbers.Add(i);
        Thread.Sleep(100);
    }
    semaphoreSlim.Release();
});
Thread thread3 = new(() =>
{
    semaphoreSlim.Wait(5000);
    int i = 20;
    while (i < 30)
    {
        Console.WriteLine($"Thread3 {++i}");
        numbers.Add(i);
        Thread.Sleep(100);
    }
    semaphoreSlim.Release();
});
thread1.Start();
thread2.Start();
thread3.Start();

//semaphoreSlim.Dispose();
#endregion