#region Interlocked Sınıfı
//int i = 0;

//var prevalue = Interlocked.Exchange(ref i, 5);
//Console.WriteLine(i);
//Console.WriteLine(prevalue);

//Interlocked.CompareExchange(ref i, 15, 5);
//Console.WriteLine(i);

//Thread thread1 = new(() =>
//{
//    while (true)
//        //i++;
//        Interlocked.Increment(ref i);
//});
//Thread thread2 = new(() =>
//{
//    while (true)
//        Console.WriteLine(i);
//});
//Thread thread3 = new(() =>
//{
//    while (true)
//        //i--;
//        Interlocked.Decrement(ref i);
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion
#region MemoryBarrier Metodu
int i = 0;
Thread writeThread = new(() =>
{
    while (true)
    {
        Interlocked.Increment(ref i);
        Thread.MemoryBarrier();
    }
});
Thread readThread = new(() =>
{
    while (true)
    {
        Thread.MemoryBarrier();
        Console.WriteLine(i);
    }
});

writeThread.Start();
readThread.Start();
#endregion