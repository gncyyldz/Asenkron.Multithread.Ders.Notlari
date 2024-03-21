#region ThreadStatic Attribute

//internal class Program
//{
//    [ThreadStatic]
//    static int x = 0;
//    private static void Main(string[] args)
//    {
//        Thread thread1 = new(() =>
//        {
//            while (x < 10)
//                Console.WriteLine($"Thread1 {++x}");
//        });

//        Thread thread2 = new(() =>
//        {
//            while (x < 10)
//                Console.WriteLine($"Thread2 {++x}");
//        });

//        Thread thread3 = new(() =>
//        {
//            while (x < 10)
//                Console.WriteLine($"Thread3 {++x}");
//        });

//        thread1.Start();
//        thread2.Start();
//        thread3.Start();
//    }
//}



#endregion
#region ThreadLocal<T> Class'ı
//ThreadLocal<int> x = new(() => 0);
//Thread thread1 = new(() =>
//{
//    while (x.Value < 10)
//        Console.WriteLine($"Thread1 {++x.Value}");
//});

//Thread thread2 = new(() =>
//{
//    while (x.Value < 10)
//        Console.WriteLine($"Thread2 {++x.Value}");
//});

//Thread thread3 = new(() =>
//{
//    while (x.Value < 10)
//        Console.WriteLine($"Thread3 {++x.Value}");
//});

//thread1.Start();
//thread2.Start();
//thread3.Start();
#endregion
#region GetData & SetData

class Program
{
    static LocalDataStoreSlot localDataStoreSlot = Thread.GetNamedDataSlot("x");
    static int X
    {
        get
        {
            var data = (int?)Thread.GetData(localDataStoreSlot);
            return data is null ? 0 : data.Value;
        }
        set => Thread.SetData(localDataStoreSlot, value);
    }

    static void Main(string[] args)
    {
        Thread thread1 = new(() =>
        {
            while (X < 10)
                Console.WriteLine($"Thread1 {++X}");
        });

        Thread thread2 = new(() =>
        {
            while (X < 10)
                Console.WriteLine($"Thread2 {++X}");
        });

        Thread thread3 = new(() =>
        {
            while (X < 10)
                Console.WriteLine($"Thread3 {++X}");
        });

        thread1.Start();
        thread2.Start();
        thread3.Start();
    }
}


#endregion