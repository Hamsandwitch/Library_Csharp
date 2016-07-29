using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RoughAnimation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Press any key for the magic.");
            Console.ReadKey();
            Console.Clear();
            string notice1 = "Rudimentary Animation Testing For a Loading Bar";
            Console.Title = "Loading Bar Test";
            Console.WriteLine("###################################");
            Console.WriteLine("#");
            Console.WriteLine($"#  {notice1}");
            Console.WriteLine("#");
            Console.WriteLine("###################################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Thread.Sleep(1000);
            Console.Clear();


            var x = "==========";
            for (var i = 1; i <= 1000; i++)
            {
                if (i >= 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine(x);
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("#=========");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=#========");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("==#=======");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("===#======");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("====#=====");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=====#====");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("======#===");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=======#==");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("========#=");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=========#");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("========#=");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=======#==");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("======#===");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=====#====");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("====#=====");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("===#======");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("==#=======");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("=#========");
                    Thread.Sleep(750);
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("#=========");
                    Thread.Sleep(750);
                    Console.Clear();
                    
                }

                else
                {
                    Console.WriteLine("something broke");
                }
                
            }

Console.ReadLine();


        }
    }
}
