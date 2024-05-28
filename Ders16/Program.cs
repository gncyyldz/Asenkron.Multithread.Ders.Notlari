//async void ReadFile()
//{
//    StreamReader streamReader = new("...");
//    var task = streamReader.ReadToEndAsync();


//    var content = await task;

//    //Action action = async () =>
//    //{

//    //};

//    return content;
//}


//await ReadFile();


// Hata Durumlarına örnek
async Task ReadFile()
{
    throw new Exception();
}


try
{
    await ReadFile();
}
catch (Exception ex)
{

}