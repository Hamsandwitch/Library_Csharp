using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_and_Enumerables
{
    public class Program
    {
        // Enumerators


        public enum Gender
        {
            Male,
            Female,
            Unknown
        }

        public enum Mood { Lazy, Female, Unknown };
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Press any key for the magic.");
            Console.ReadKey();
            Console.Clear();
            string notice1 = "This will be a representation of collections.";
            Console.Title = "Collections and Enumerables";
            Console.WriteLine("###########################################################");
            Console.WriteLine("#");
            Console.WriteLine($"#  {notice1}");
            Console.WriteLine("#");
            Console.WriteLine("###########################################################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");


            var theList = new List<int>();
            theList.Add(1);
            theList.Add(2);

            var myList2 =

                new List<int>
                {
            1,
            2
                };

            //Arrays
            var theArray = new int[3];

            theArray[0] = 1;
            theArray[1] = 2;

            var theArray2 = new int[] { 1, 2, 3 };


            Console.WriteLine(theArray[1]);
            Console.WriteLine(" ");
            Console.WriteLine($"Here is an array's value parsed inside a string, {theArray2[2]}");
            Console.ReadLine();

            //Dictionaries

            var myDictionary = new Dictionary<int, string>(); // <TKey, TValue>

            myDictionary.Add(1, "Sunday");
            myDictionary.Add(2, "Monday");
            myDictionary.Add(3, "Tuesday");
            myDictionary[1] = "Sunday"; // alternate definition option.


            var myDictionary2 = // an index, parameters reversed.
                new Dictionary<string, int>
                {
                    {"Sunday", 1},
                    {"Monday", 2},
                    {"Tuesday", 3}
                };
















        }
    }
}
