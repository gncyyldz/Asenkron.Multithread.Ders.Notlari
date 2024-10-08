using System.Threading.Channels;

var channel = Channel.CreateBounded<int>(5);

Task producer = Task.Run(async () =>
{
    for (int i = 0; i < 50; i++)
    {
        await channel.Writer.WriteAsync(i);
        await Console.Out.WriteLineAsync($"Üretilen : {i}");
        await Task.Delay(1000);
    }

    channel.Writer.Complete();
});


Task consumer = Task.Run(async () =>
{
    await foreach (var result in channel.Reader.ReadAllAsync())
    {
        await Console.Out.WriteLineAsync($"Tüketilen : {result}");
        await Task.Delay(3000);
    }
});

await Task.WhenAll(producer, consumer);

Console.Read();