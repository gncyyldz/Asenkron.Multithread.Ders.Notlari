#region Thread Sınıfı
//class Program
//{
//    private static void Main(string[] args)
//    {
//        //Thread thread = new(ThreadMethod);
//        Thread thread = new((o) =>
//        {
//            for (int i = 0; i < 999; i++)
//            {
//                Console.WriteLine($"Worker Thread {i}");
//            }
//        });

//        thread.Start();
//        for (int i = 0; i < 999; i++)
//        {
//            Console.WriteLine($"Main Thread {i}");
//        }
//    }

//static void ThreadMethod()
//{

//}
//}
#endregion
#region Thread Id
//class Program
//{
//    private static void Main(string[] args)
//    {
//        Console.WriteLine("Main Thread");
//        Console.WriteLine(Environment.CurrentManagedThreadId);
//        Console.WriteLine(AppDomain.GetCurrentThreadId());
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//        Thread thread1 = new(() =>
//        {
//            Console.WriteLine("Worker 1 Thread");
//            Console.WriteLine(Environment.CurrentManagedThreadId);
//            Console.WriteLine(AppDomain.GetCurrentThreadId());
//            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//        });

//        thread1.Start();
//        Thread thread2 = new(() =>
//        {
//            Console.WriteLine("Worker 2 Thread");
//            Console.WriteLine(Environment.CurrentManagedThreadId);
//            Console.WriteLine(AppDomain.GetCurrentThreadId());
//            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//        });

//        thread2.Start();
//    }
//}
#endregion
#region IsBackground
//int i = 10;
//Thread thread = new(() =>
//{
//    while (i >= 0)
//    {
//        i--;
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine($"Worker Thread görevini tamamladı.");
//});
//thread.IsBackground = true;
//thread.Start();
//Console.WriteLine($"Main Thread görevini tamamladı.");
#endregion
#region Thread State
//int i = 10;
//Thread thread = new(() =>
//{
//    while (i >= 0)
//    {
//        i--;
//        Thread.Sleep(1000);
//    }
//    Console.WriteLine($"Worker Thread görevini tamamladı.");
//});

//thread.Start();

//ThreadState state = ThreadState.Running;
//while (true)
//{
//    if (thread.ThreadState == ThreadState.Stopped)
//        break;

//    if (state != thread.ThreadState)
//    {
//        state = thread.ThreadState;
//        Console.WriteLine(thread.ThreadState);
//    }
//}

//Console.WriteLine($"Main Thread görevini tamamladı.");
#endregion
#region Locking
//object locking = new();
//int i = 1;

//Thread thread1 = new(() =>
//{
//    lock (locking)
//    {
//        while (i < 10)
//        {
//            i++;
//            Console.WriteLine($"Thread 1 : {i}");
//        }
//    }
//});
//Thread thread2 = new(() =>
//{
//    lock (locking)
//    {
//        while (i > 0)
//        {
//            i--;
//            Console.WriteLine($"Thread 2 : {i}");
//        }
//    }
//});
//thread1.Start();
//thread2.Start();
#endregion
#region Sleep
//Thread thread = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }
//});
//thread.Start();
#endregion
#region Join
//Thread thread1 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread 1 {i}");
//    }
//});
//Thread thread2 = new(() =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread 2 {i}");
//    }
//});

//thread1.Start();
//thread1.Join();
//thread2.Start();
#endregion
#region Thread İptal Etme
//bool stop = false;
//Thread thread = new(() =>
//{
//    while (true)
//    {
//        if (stop) break;
//        Console.WriteLine("askdaksmdk");
//    }
//    Console.WriteLine("Thread görevini tamamladı.");
//});


//Thread thread = new((cancellationToken) =>
//{
//    var cancel = (CancellationTokenSource)cancellationToken;
//    while (true)
//    {
//        if (cancel.IsCancellationRequested) break;
//        Console.WriteLine("askdaksmdk");
//    }
//    Console.WriteLine("Thread görevini tamamladı.");
//});
//CancellationTokenSource cancellationToken = new();
//thread.Start(cancellationToken);
//Thread.Sleep(5000);
//cancellationToken.Cancel();
#endregion
#region Interrupt
Thread thread = new(() =>
{
    try
    {
        Thread.Sleep(Timeout.Infinite);
    }
    catch (ThreadInterruptedException ex)
    {

    }
});

thread.Start();
thread.Interrupt();
#endregion