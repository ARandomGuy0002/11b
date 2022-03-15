using System;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass threadClass = new ThreadClass();
            Thread thread1 = new Thread(
            new ThreadStart(threadClass.DoTask1));
            Thread thread2 = new Thread(
            new ThreadStart(threadClass.DoTask2));
            thread1.Start();
            thread2.Start();
        }
    }
}
