#region Thread Pool
//ThreadPool.SetMaxThreads(4, 4);
//ThreadPool.SetMinThreads(2, 2);

//ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 1");
//ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 2");
//ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 3");
//ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 4");
//ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 5");
//ThreadPool.QueueUserWorkItem(WorkerMethod, "Task 6");

//Console.Read();

//void WorkerMethod(object state)
//{
//    Console.WriteLine($"*** Thread Count : {ThreadPool.ThreadCount}");
//    string name = (string)state;
//    Console.WriteLine($"{name} işi başladı");
//    Thread.Sleep(new Random().Next(1000, 5000));
//    Console.WriteLine($"{name} işi tamamlandı");
//}
#endregion
#region RegisterWaitForSingleObject
//AutoResetEvent autoResetEvent = new(false);

//RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(autoResetEvent, WorkerMethod, "Task 1 Wait Handle", -1, true); //Time Out süresiz!
//                                                                                                                                                  //RegisteredWaitHandle registeredWaitHandle = ThreadPool.RegisterWaitForSingleObject(autoResetEvent, WorkerMethod, "Task 1 Wait Handle", 15000, true); //1,5 saniye boyunca set edilmezse otomatik faal hale gelecektir!

//Thread.Sleep(2500);
//autoResetEvent.Set();

//registeredWaitHandle.Unregister(autoResetEvent);
//Console.Read();


//void WorkerMethod(object state, bool timedOut)
//{
//    Console.WriteLine($"*** Thread Count : {ThreadPool.ThreadCount}");
//    string name = (string)state;
//    Console.WriteLine($"{name} işi başladı");
//    Thread.Sleep(new Random().Next(1000, 5000));
//    Console.WriteLine($"{name} işi tamamlandı");
//}
#endregion
#region WaitHandle.WaitAll
//AutoResetEvent autoResetEvent1 = new(false);
//AutoResetEvent autoResetEvent2 = new(false);
//ManualResetEvent manualResetEvent1 = new(false);
//ManualResetEvent manualResetEvent2 = new(false);

//autoResetEvent1.Set();
//autoResetEvent2.Set();
//manualResetEvent1.Set();
//manualResetEvent2.Set();

//WaitHandle.WaitAll(new WaitHandle[]
//{
//    autoResetEvent1, autoResetEvent2 , manualResetEvent1 , manualResetEvent2
//});
//Console.WriteLine("Merhaba");
//Console.ReadLine();
#endregion
#region WaitHandle.WaitAny
//AutoResetEvent autoResetEvent1 = new(false);
//AutoResetEvent autoResetEvent2 = new(false);
//ManualResetEvent manualResetEvent1 = new(false);
//ManualResetEvent manualResetEvent2 = new(false);

//manualResetEvent1.Set();

//WaitHandle.WaitAny(new WaitHandle[]
//{
//    autoResetEvent1, autoResetEvent2 , manualResetEvent1 , manualResetEvent2
//});
//Console.WriteLine("Merhaba");
//Console.ReadLine();
#endregion
#region WaitHandle.SignalAndWait
AutoResetEvent autoResetEvent1 = new(false);
AutoResetEvent autoResetEvent2 = new(false);

autoResetEvent1.Set();
autoResetEvent2.Set();

WaitHandle.SignalAndWait(autoResetEvent1, autoResetEvent2);
Console.WriteLine("Merhaba");
Console.ReadLine();
#endregion