#region PLINQ - Ordering
var numbers = Enumerable.Range(1, 999999999);
var result = numbers
    .AsParallel()
    .AsOrdered()
    .Where(n => n % 7777 == 0);

foreach (var number in result)
{
    Console.WriteLine(number);
}
#endregion