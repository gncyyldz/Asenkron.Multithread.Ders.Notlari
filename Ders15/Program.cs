#region TaskFactory
#region StartNew
//TaskFactory taskFactory = new();
//taskFactory.StartNew(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine(i);
//});
#endregion
#region ContinueWhenAll
//Task task1 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine($"Task 1 {i}");
//});
//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine($"Task 2 {i}");
//});
//Task task3 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine($"Task 3 {i}");
//});

//TaskFactory taskFactory = new();
//taskFactory.ContinueWhenAll(new[] { task1, task2, task3 }, (tasks) =>
//{
//    Console.WriteLine("....");
//});

//Console.WriteLine("merhaba");
#endregion
#region ContinueWhenAny
//Task task1 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine($"Task 1 {i}");
//});
//Task task2 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine($"Task 2 {i}");
//});
//Task task3 = Task.Run(() =>
//{
//    for (int i = 0; i < 10; i++)
//        Console.WriteLine($"Task 3 {i}");
//});

//TaskFactory taskFactory = new();
//taskFactory.ContinueWhenAny(new[] { task1, task2, task3 }, (tasks) =>
//{
//    Console.WriteLine("....");
//});
#endregion
#endregion
#region TaskScheduler
//Task.Factory.StartNew(() =>
//{
//    //...
//}, new(), TaskCreationOptions.None, new CustomTaskScheduler());

//class CustomTaskScheduler : TaskScheduler
//{
//    protected override IEnumerable<Task>? GetScheduledTasks()
//        => null;

//    protected override void QueueTask(Task task)
//        => ThreadPool.QueueUserWorkItem(_ =>
//        {
//            TryExecuteTask(task);
//        });

//    protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
//        => true;
//}
#endregion
#region TaskCompletionSource
Task<int> Operation(ResultType resultType)
{
    TaskCompletionSource<int> taskCompletionSource = new();
    switch (resultType)
    {
        case ResultType.Result:
            taskCompletionSource.SetResult(42);
            break;
        case ResultType.Exception:
            taskCompletionSource.SetException(new Exception("Hata alındı!"));
            break;
        case ResultType.Canceled:
            taskCompletionSource.SetCanceled();
            break;
    }
    return taskCompletionSource.Task;
}
var task = Operation(ResultType.Canceled);
Console.WriteLine();
enum ResultType
{
    Result,
    Exception,
    Canceled
}

#endregion
