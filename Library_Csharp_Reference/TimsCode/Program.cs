using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBar
{
    class Program
    {
        public static string BarLoop(int count)
        {
            var bar = "";
            for (var i = 0; i <= 16 - count; i++)
            {
                bar += " ";
            }
            for (var i = 0; i <= count; i++)
            {
                bar += "==";
            }
            for (var i = 0; i <= 16 - count; i++)
            {
                bar += " ";
            }
            return bar;
        }
        static void Main(string[] args)
        {


            var count = 0;
            bool increase = true;

            for (var x = 0; x < 256; x++)
            {
                Console.Clear();
                for (var y = 0; y < 12; y++)
                {
                    Console.WriteLine();
                }
                if (count == 16)
                {
                    increase = false;
                }
                if (count == 0)
                {
                    increase = true;
                }
                Console.WriteLine(BarLoop(count));
                if (increase == true)
                {
                    count += 1;
                }
                else
                {
                    count -= 1;
                }
                Thread.Sleep(75);
            }
            Console.ReadLine();
        }
    }
}