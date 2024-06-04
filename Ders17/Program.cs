#region ConfigureAwait
//async Task<string> ReadFileAsync(string path)
//{
//    StreamReader streamReader = new(path);
//    var content = await streamReader.ReadToEndAsync()
//        .ConfigureAwait(false);
//    Console.WriteLine("End.");
//    return content;
//}

//var content = await ReadFileAsync("C:\\Users\\Gencay\\Downloads\\OAuth 2.0 Avantajları.html");
//Console.WriteLine(content);
#endregion
#region CancellationToken & CancellationTokenSource 

//async Task DoWorkAsync(CancellationToken cancellationToken)
//{
//    for (int i = 0; i < 10; i++)
//    {
//        cancellationToken.ThrowIfCancellationRequested();
//        await Console.Out.WriteLineAsync($"{i}");
//        await Task.Delay(1000);
//    }
//    Console.WriteLine("Work completed...");
//}

//CancellationTokenSource cancellationTokenSource = new();

//Task.Run(async () =>
//{
//    await Task.Delay(3000);
//    await cancellationTokenSource.CancelAsync();
//});

//try
//{
//    await DoWorkAsync(cancellationTokenSource.Token);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

#endregion
#region Task & ValueTask
async Task X()
{

}
async ValueTask Y()
{

}

await X();
await Y();
#endregion