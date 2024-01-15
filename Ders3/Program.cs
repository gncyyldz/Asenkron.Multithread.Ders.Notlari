#region Spinning
//bool threadCondition = true;
//Thread thread1 = new(() =>
//{
//    while (true)
//    {
//        if (!threadCondition)
//        {
//            for (int i = 1; i <= 10; i++)
//                Console.WriteLine($"Thread 1 {i}.");
//            threadCondition = false;
//            break;
//        }
//    }
//});
//Thread thread2 = new(() =>
//{
//    while (true)
//    {
//        if (threadCondition)
//        {
//            for (int i = 10; i > 0; i--)
//                Console.WriteLine($"Thread 2 {i}.");
//            threadCondition = false;
//            break;
//        }
//    }
//});

//thread1.Start();
//thread2.Start();
#endregion
#region Monitor.Enter ve Monitor.Exit 
//object locking = new();
//int i = 0;
//Thread thread1 = new(() =>
//{
//    try
//    {
//        Monitor.Enter(locking);
//        for (i = 0; i < 10; i++)
//            Console.WriteLine($"Thread 1 {i}");
//    }
//    finally
//    {
//        Monitor.Exit(locking);
//    }
//});
//Thread thread2 = new(() =>
//{
//    try
//    {
//        Monitor.Enter(locking);
//        for (i = 0; i < 10; i++)
//            Console.WriteLine($"Thread 2 {i}");
//    }
//    finally
//    {
//        Monitor.Exit(locking);
//    }
//});
//thread1.Start();
//thread2.Start();

#region lockTaken
//object locking = new();
//int i = 0;
//Thread thread1 = new(() =>
//{
//    try
//    {
//        bool lockTaken = false;
//        Monitor.Enter(locking, ref lockTaken);
//        if (lockTaken)
//            for (i = 0; i < 10; i++)
//                Console.WriteLine($"Thread 1 {i}");
//    }
//    finally
//    {
//        Monitor.Exit(locking);
//    }
//});
//Thread thread2 = new(() =>
//{
//    try
//    {
//        bool lockTaken = false;
//        Monitor.Enter(locking, ref lockTaken);
//        if (lockTaken)
//            for (i = 0; i < 10; i++)
//                Console.WriteLine($"Thread 2 {i}");
//    }
//    finally
//    {
//        Monitor.Exit(locking);
//    }
//});
//thread1.Start();
//thread2.Start();
#endregion
#endregion
#region Monitor.TryEnter
//object locking = new();
//int i = 0;
//Thread thread1 = new(() =>
//{
//    var result = Monitor.TryEnter(locking, 100);
//    if (result)
//        try
//        {
//            for (i = 0; i < 10; i++)
//                Console.WriteLine($"Thread 1 {i}");
//        }
//        finally
//        {
//            Monitor.Exit(locking);
//        }
//});
//Thread thread2 = new(() =>
//{
//    var result = Monitor.TryEnter(locking, 1);
//    if (result)
//        try
//        {
//            for (i = 0; i < 10; i++)
//                Console.WriteLine($"Thread 2 {i}");
//        }
//        finally
//        {
//            Monitor.Exit(locking);
//        }
//});
//thread1.Start();
//thread2.Start();
#endregion
#region Mutex Sınıfı
//Mutex mutex = new();
//Thread thread1 = new(() =>
//{
//    mutex.WaitOne();
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread 1 {i}");
//    }
//    mutex.ReleaseMutex();
//});
//Thread thread2 = new(() =>
//{
//    mutex.WaitOne();
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine($"Thread 2 {i}");
//    }
//    mutex.ReleaseMutex();
//});
//thread1.Start();
//thread2.Start();

#region Mutex İle Single Instance Application
//internal class Program
//{
//    static Mutex _mutex;
//    static string _programName = "Example Project";
//    private static void Main(string[] args)
//    {
//        Mutex.TryOpenExisting(_programName, out _mutex);
//        if (_mutex == null)
//        {
//            _mutex = new(true, _programName);
//            Console.WriteLine("Program ayakta....");
//            Console.Read();
//        }
//        else
//        {
//            _mutex.Close();
//            return;
//        }
//    }
//}
#endregion
#endregion
#region Locking

#endregion