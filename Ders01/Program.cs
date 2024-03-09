X();
Y();

Console.ReadLine();

async void X()
{
    await Task.Run(() =>
     {
         for (int i = 0; i < 999; i++)
             Console.WriteLine($"X - {i}");
     });
}
async void Y()
{
    await Task.Run(() =>
    {
        for (int i = 0; i < 999; i++)
            Console.WriteLine($"Y - {i}");
    });
}