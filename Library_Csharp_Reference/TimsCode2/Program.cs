using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBunny
{
    class Program
    {
        public static string BarLoop(int count, int line)
        {
            var top = @"(\ /)   ";
            var mid = "(^-^)   ";
            var bottom = @"(("")("") ";
            var lineString = "";

            for (var i = 0; i <= count; i++)
            {
                if (line == 0)
                {
                    lineString += top;
                }
                if (line == 1)
                {
                    lineString += mid;
                }
                if (line == 2)
                {
                    lineString += bottom;
                }
            }
            return lineString;
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
                if (count == 7)
                {
                    increase = false;
                }
                if (count == 0)
                {
                    increase = true;
                }
                for (var z = 0; z < 3; z++)
                {
                    Console.WriteLine(BarLoop(count, z));
                }

                if (increase == true)
                {
                    count += 1;
                }
                else
                {
                    count -= 1;
                }
                Thread.Sleep(150);
            }
            Console.ReadLine();
        }
    }
}