using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        //5 adet reader thread oluşturuluyor...
        for (int i = 0; i < 5; i++)
            new Thread(Read).Start();
        //2 adet writer thread oluşturuluyor...
        for (int i = 0; i < 2; i++)
            new Thread(Write).Start();
    }
    static ReaderWriterLockSlim readerWriterLockSlim = new();
    static int counter = 0;
    static void Read()
    {
        for (int i = 0; i < 10; i++)
        {
            try
            {
                readerWriterLockSlim.EnterReadLock();
                Console.WriteLine($"R : Thread {Thread.CurrentThread.ManagedThreadId} is reading : {counter}");
            }
            finally
            {
                readerWriterLockSlim.ExitReadLock();
            }
            Thread.Sleep(1000);
        }
    }
    static void Write()
    {

        try
        {
            readerWriterLockSlim.EnterWriteLock();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"W : Thread {Thread.CurrentThread.ManagedThreadId} is writing : {++counter}");
                Thread.Sleep(200);
            }
        }
        finally
        {
            readerWriterLockSlim.ExitWriteLock();
        }
    }
}
