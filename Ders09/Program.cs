
#region AutoResetEvent
//AutoResetEvent autoResetEvent = new(false);
//Thread thread1 = new(() =>
//{
//    Console.WriteLine("Thread1");
//    autoResetEvent.Set();
//});
//Thread thread2 = new(() =>
//{
//    autoResetEvent.WaitOne();
//    Console.WriteLine("Thread2");
//    autoResetEvent.Set();
//});
//Thread thread3 = new(() =>
//{
//    autoResetEvent.WaitOne();
//    Console.WriteLine("Thread3");
//    autoResetEvent.Set();
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion
#region ManualResetEventSlim
//ManualResetEventSlim manualResetEventSlim = new(false);
//Thread thread1 = new(() =>
//{
//    Console.WriteLine("Thread1");
//    manualResetEventSlim.Set();
//});
//Thread thread2 = new(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        manualResetEventSlim.Wait();
//        Console.WriteLine("Thread2");
//        manualResetEventSlim.Reset();
//    }
//});
//Thread thread3 = new(() =>
//{
//    manualResetEventSlim.Wait();
//    for (int i = 0; i < 5; i++)
//    {
//        manualResetEventSlim.Wait();
//        Console.WriteLine("Thread3");
//        manualResetEventSlim.Reset();
//    }
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion
#region EventWaitHandle
//EventWaitHandle eventWaitHandle = new(false, EventResetMode.AutoReset);
//EventWaitHandle eventWaitHandle = new(false, EventResetMode.ManualReset);
//Thread thread1 = new(() =>
//{
//    Console.WriteLine("Thread1");
//    eventWaitHandle.Set();
//});
//Thread thread2 = new(() =>
//{
//    eventWaitHandle.WaitOne();
//    Console.WriteLine("Thread2");
//});
//Thread thread3 = new(() =>
//{
//    eventWaitHandle.WaitOne();
//    Console.WriteLine("Thread3");
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion
#region CountdownEvent
CountdownEvent countdownEvent = new(3);

Thread thread1 = new(() =>
{
    Console.WriteLine("Thread1");
    Thread.Sleep(1000);
    countdownEvent.Signal();
});
Thread thread2 = new(() =>
{
    Console.WriteLine("Thread2");
    Thread.Sleep(5500);
    countdownEvent.Signal();
});
Thread thread3 = new(() =>
{
    Console.WriteLine("Thread3");
    Thread.Sleep(800);
    countdownEvent.Signal();
});
Thread thread4 = new(() =>
{
    countdownEvent.Wait();
    Console.WriteLine("Thread4");
});

thread1.Start();
thread2.Start();
thread3.Start();
thread4.Start();

//countdownEvent.Wait();
//Console.WriteLine("İşlem devam ediyor...");
#endregion