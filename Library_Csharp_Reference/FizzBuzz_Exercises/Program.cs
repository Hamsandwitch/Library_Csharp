using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_Exercises
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
            string notice1 = "FizzBuzz Solution";
            Console.Title = "Fizzbuz";
            Console.WriteLine("###################################################################");
            Console.WriteLine("#");
            Console.WriteLine($"#  {notice1}");
            Console.WriteLine("#");
            Console.WriteLine("###################################################################");

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            var i = 0;
            for (i = 0; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

//                Console.ReadLine();
            }
            Console.ReadLine();
        }      

    }
}
