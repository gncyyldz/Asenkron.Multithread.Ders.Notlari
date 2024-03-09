#region SpinLock
//int value = 0;
//SpinLock spinLock = new();
//Thread thread1 = new(() =>
//{
//    bool lockTaken = false;
//    try
//    {
//        spinLock.Enter(ref lockTaken);
//        if (lockTaken)
//            for (int i = 0; i < 999; i++)
//                Console.WriteLine($"Thread1 : {++value}");
//    }
//    finally
//    {
//        spinLock.Exit();
//    }
//});
//Thread thread2 = new(() =>
//{
//    bool lockTaken = false;
//    try
//    {
//        spinLock.Enter(ref lockTaken);
//        if (lockTaken)
//            for (int i = 0; i < 999; i++)
//                Console.WriteLine($"Thread2 : {++value}");
//    }
//    finally
//    {
//        spinLock.Exit();
//    }
//});

//thread1.Start();
//thread2.Start();
#endregion
#region SpinWait
bool waitMod = false, condition = false;
Thread thread1 = new(() =>
{
    while (true)
    {
        if (waitMod)
        {
            continue;
        }

        if (!condition)
        {
            continue;
        }

        Console.WriteLine("Thread1 işleniyor...");
    }
});

Thread thread2 = new(() =>
{
    while (true)
    {
        SpinWait.SpinUntil(() =>
        {
            Thread.MemoryBarrier();
            return waitMod || condition;
        });

        Console.WriteLine("Thread2 işleniyor...");
    }
});

thread1.Start();
thread2.Start();
#endregion