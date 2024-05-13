using System;
using System.Threading;

class program
{
    public void workThreadFunction()
    {
        // Check the thread ID to determine which message to print
        if (Thread.CurrentThread.ManagedThreadId == 12)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 1: C# trådning er nemt!");
                Thread.Sleep(1000);
            }
        }
        else if (Thread.CurrentThread.ManagedThreadId == 13)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Thread 2: også med flere ...");
                Thread.Sleep(1000);
            }
        }
    }
}

class threprog
{
    public static void Main()
    {
        program pg = new program();

        Thread thread1 = new Thread(new ThreadStart(pg.workThreadFunction));
        thread1.Start();

        Thread thread2 = new Thread(new ThreadStart(pg.workThreadFunction));
        thread2.Start();

        Console.Read();
    }
}