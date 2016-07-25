using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string notice1 = "This will be a representation of basic type definitions.";
            Console.Title = "Basic Types";
            Console.WriteLine("###########################################################");
            Console.WriteLine("#");
            Console.WriteLine($"#  {notice1}");
            Console.WriteLine("#");
            Console.WriteLine("###########################################################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            //Basic type declarations:

            char theChar = 'c';
            string theString = "Heres a string!";
            int theInteger = 37;
            double theDouble = 2.7;
            decimal theDecimal = 7.2m;
            short theShort = 32767;
            long theLong = 128;
            byte theByte = 255;
            float theFloat = 10.8f; // suffix 'f' on end of number, forces the float type.
            var theVar = "Any type";


            // Reference Types

            //object 0 = new object();

            string s1 = "A regular string."; // normal string

            string s2 = "This is a \r\nmulti-line string."; // \r \n are return-line

            string s3 = @"This is a \r\nverbatim-line string."; // @ character before string, prints exact

            string s4 = $"A string with variables like: \r\n {theFloat} & {theString} & {theInteger}!"; // $ before string results in a parse of the string for variables to be written.



            Console.WriteLine(s1);
            Console.WriteLine(" ");
            Console.WriteLine(s2);
            Console.WriteLine(" ");
            Console.WriteLine(s3);
            Console.WriteLine(" ");
            Console.WriteLine(s4);
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}