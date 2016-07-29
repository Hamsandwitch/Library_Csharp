using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEnumFunction
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
            string notice1 = "Using an enumerator inside a function.";
            Console.Title = "Enumerator Function";
            Console.WriteLine("###################################################################");
            Console.WriteLine("#");
            Console.WriteLine($"#  {notice1}");
            Console.WriteLine("#");
            Console.WriteLine("###################################################################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var theArray = new string[7];
            theArray[0] = "Dobbers";
            theArray[1] = "Dobby";
            theArray[2] = "Pdiddy";
            theArray[3] = "Patwick";
            theArray[4] = "Patty";
            theArray[5] = "Patronus";
            theArray[6] = "DubOfSon";

            Console.WriteLine("### Results 1 ###");
            foreach (var name in theArray)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(" ");//alt method //spacer line

            Console.WriteLine("### Results 2 ###");
            for (int y = 0; y < theArray.Length; y++)
            {
                Console.WriteLine(theArray[y]);
            }
            Console.ReadLine();
        }
    }
}


