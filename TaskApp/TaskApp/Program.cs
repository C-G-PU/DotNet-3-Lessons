using System;
using System.Threading.Tasks;
using System.Threading;

namespace TaskApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = 0;
            Task task = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    a++;
                }
            });
            task.Start();
            Thread.Sleep(400);
            
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
