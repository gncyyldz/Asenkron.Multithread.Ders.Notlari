#region PLINQ & Cancellation
var cancellationTokenSource = new CancellationTokenSource();

var numbers = Enumerable.Range(0, 100000);
var _numbers = numbers
  .AsParallel()
  .WithCancellation(cancellationTokenSource.Token)
  .Where(n => n % 4 == 0)
  .Select(n => n * n);

Task.Run(() =>
{
    Thread.Sleep(1000);
    cancellationTokenSource.Cancel();
});

foreach (var number in _numbers)
    Console.WriteLine(number);

Console.Read();
#endregion
