
#region new Task
//Task task = new Task(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine(i);
//});
//task.Start();
#endregion
#region Task.Run
//Task task = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine(i);
//});
#endregion
#region Task.Factory.StartNew
//Task task = Task.Factory.StartNew(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine(i);
//});
#endregion

//Metotlar
Task task = Task.Run(() =>
{
    for (int i = 0; i < 10; i++)
        Console.WriteLine(i);
});
#region Start
//task.Start();
#endregion
#region Wait
//task.Wait();
//Console.WriteLine("merhaba");
#endregion
#region ContinueWith
//task.ContinueWith((_task) =>
//{
//    Console.WriteLine("İşlem tamamlandı");
//});
#endregion
#region WaitAll
//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine(i + "task2");
//});
//Task task3 = Task.Run(() =>
//{
//    for (int i = 0; i < 300; i++)
//        Console.WriteLine(i + "task3");
//});
//Task.WaitAll(task, task2, task3);
//Console.WriteLine("merhaba");
#endregion
#region WhenAll
//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine(i + "task2");
//});
//Task task3 = Task.Run(() =>
//{
//    for (int i = 0; i < 300; i++)
//        Console.WriteLine(i + "task3");
//});
//Task.WhenAll(task, task2, task3);
//Console.WriteLine("merhaba");
#endregion
#region WaitAny
//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine(i + "task2");
//});
//Task task3 = Task.Run(() =>
//{
//    for (int i = 0; i < 300; i++)
//        Console.WriteLine(i + "task3");
//});
//Task.WaitAny(task, task2, task3);
//Console.WriteLine("merhaba");
#endregion
#region WhenAny
//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine(i + "task2");
//});
//Task task3 = Task.Run(() =>
//{
//    for (int i = 0; i < 300; i++)
//        Console.WriteLine(i + "task3");
//});
//Task.WhenAny(task, task2, task3);
//Console.WriteLine("merhaba");
#endregion
#region Delay
//Task task1 = Task.Run(async () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Task.Delay(1000);
//        Console.WriteLine(i);
//    }
//});
#endregion
#region FromCancelled
//Task task2 = Task.Run(() =>
//{
//    return Task.FromCanceled(new());
//});
#endregion
#region FromException
//Task task1 = Task.FromException(new("Hata alındı!"));
#endregion
#region FromResult
//Task<int> task1 = Task.Run<int>(() => 35);
//var result = task1.Result;

//Task<int> task1 = Task.FromResult(35);
#endregion
#region Yield

#endregion
#region GetAwaiter
//Task<int> task1 = Task.Run(() => 3);
//var result = task1.Result;

//var result2 = task1
//    .GetAwaiter()
//    .GetResult();
#endregion

//Propertyler
#region CompletedTask
//Task X()
//{
//    //......
//    //return Task.Run(() => { });
//    //return new Task(() => { });
//    return Task.CompletedTask;
//}
#endregion
#region CurrentId
//Task task1 = Task.Run(() =>
//{
//    Console.WriteLine($"Task1 Current Id : {Task.CurrentId}");
//});
//Task task2 = Task.Run(() =>
//{
//    Console.WriteLine($"Task2 Current Id : {Task.CurrentId}");
//});
//Task task3 = Task.Run(() =>
//{
//    Console.WriteLine($"Task3 Current Id : {Task.CurrentId}");
//});
//Task task4 = Task.Run(() =>
//{
//    Console.WriteLine($"Task4 Current Id : {Task.CurrentId}");
//});
#endregion
#region Factory

#endregion
#region IsCompleted

#endregion
#region IsCanceled

#endregion
#region AsyncState
//var task1 = Task.Factory.StartNew((i) =>
//{
//    var _i = (int)i;
//    for (int j = 0; j < _i; j++)
//        Console.WriteLine("Merhaba");
//}, 10);
//var state = task1.AsyncState;
#endregion
#region IsCompletedSuccessfully

#endregion
#region Id

#endregion
#region IsFaulted

#endregion
#region Status
//Task task2 = Task.Run(async () =>
//{
//    for (int i = 0; i < 10; i++)
//    {
//        await Task.Delay(1000);
//        Console.WriteLine(i);
//    }
//});

//TaskStatus? status = null;
//while (true)
//{
//    if (status != task2.Status)
//    {
//        Console.WriteLine(task2.Status);
//        status = task2.Status;
//    }
//}
#endregion

Console.Read();