using System.Collections.Concurrent;
using System.Linq;
#region ConcurrentBag<T>
//ConcurrentBag<int> numbers = new();

//Task producer = Task.Run(async () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        numbers.Add(i);
//        await Console.Out.WriteLineAsync($"P : {i}");
//        await Task.Delay(500);
//    }
//});

//Task consumer = Task.Run(async () =>
//{
//    while (true)
//    {
//        if (numbers.TryTake(out int result))
//        {
//            await Console.Out.WriteLineAsync($"C : {result}");
//        }
//        else
//            await Task.Delay(500);
//    }
//});

//await Task.WhenAny(producer, consumer);
#endregion
#region BlockingCollection<T>
//BlockingCollection<int> numbers = new();

//Task producer = Task.Run(async () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        numbers.Add(i);
//        Console.WriteLine($"P : {i}");
//        await Task.Delay(500);
//    }
//    numbers.CompleteAdding();
//});

//Task consumer = Task.Run(() =>
//{
//    try
//    {
//        while (true)
//        {
//            int result = numbers.Take();
//            Console.WriteLine($"C : {result}");
//        }
//    }
//    catch (Exception ex)
//    {

//    }
//});

//await Task.WhenAny(producer, consumer);
//Console.Read();
#endregion
#region ConcurrentStack<T>
//ConcurrentStack<int> numbers = new();

//Task producer = Task.Run(async () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        numbers.Push(i);
//        Console.WriteLine($"P : {i}");
//        await Task.Delay(100);
//    }
//});

//Task consumer = Task.Run(async () =>
//{
//    await Task.Delay(3000);
//    while (true)
//    {
//        if (numbers.TryPop(out int result))
//        {
//            Console.WriteLine($"C : {result}");
//            await Task.Delay(100);
//        }
//    }
//});

//await Task.WhenAny(producer, consumer);

//Console.Read();
#endregion
#region ConcurrentQueue<T>
//ConcurrentQueue<int> numbers = new();

//Task producer = Task.Run(async () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        numbers.Enqueue(i);
//        Console.WriteLine($"P : {i}");
//        await Task.Delay(100);
//    }
//});

//Task consumer = Task.Run(async () =>
//{
//    await Task.Delay(3000);
//    while (true)
//    {
//        if (numbers.TryDequeue(out int result))
//        {
//            Console.WriteLine($"C : {result}");
//            await Task.Delay(100);
//        }
//    }
//});

//await Task.WhenAny(producer, consumer);

//Console.Read();
#endregion
#region ConcurrentDictionary<TKey, TValue>
ConcurrentDictionary<int, int> numbers = new();
Task producer = Task.Run(async () =>
{
    for (int i = 0; i < 5; i++)
    {
        numbers[i] = i * 5;
        Console.WriteLine($"P : '{i}' key'ine karşılık '{i * 5}' değeri verilmiş.");
        await Task.Delay(100);
    }
});

Task consumer = Task.Run(async () =>
{
    await Task.Delay(1000);
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"C : '{i}' key'ine karşılık '{numbers[i]}' değeri okunmuştur.");
        await Task.Delay(300);
    }
});

await Task.WhenAny(producer, consumer);
Console.Read();
#endregion