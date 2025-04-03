#region Deffered Execution
//var numbers = Enumerable.Range(0, 9999999);

//var datas = numbers
//    .AsParallel()
//    .Where(n => n % 7 == 0);

//int i = 0;
//if (i == 0)
//    datas = datas
//        .Where(n => true);

//foreach (var data in datas)
//{

//}
#endregion
#region Veri Kümesini Bölme (Partitioning)
using System.Collections.Concurrent;

var numbers = Enumerable.Range(0, 9999999);

var partitioner = Partitioner.Create(numbers);

var datas = partitioner
    .AsParallel()
    .Where(n => n % 5 == 0)
    .Select(n => n * n);

foreach (var data in datas)
{
    Console.WriteLine(data);
}
#endregion
