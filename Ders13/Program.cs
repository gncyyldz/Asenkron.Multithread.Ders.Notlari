#region System.Threading.Timer
//Timer timer = new(state =>
//{
//    Console.WriteLine(state);
//}, "Tick!", 200, Timeout.Infinite);

//Thread.Sleep(1000);
////timer.Change(0, 1500);

//Console.Read();
#endregion
#region System.Timers.Timer
System.Timers.Timer timer = new();
timer.Elapsed += (sender, e) =>
{
    Console.WriteLine("asdlamsdk");
};
timer.Start();
timer.Interval = 500;
timer.Stop();

Thread.Sleep(1000);
//timer.Change(0, 1500);

Console.Read();
#endregion