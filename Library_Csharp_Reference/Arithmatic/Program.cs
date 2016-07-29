using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Press any key for the magic.");
            Console.ReadKey();
            Console.Clear();
            string notice1 = "This will be a representation of basic arithmetic operations.";
            Console.Title = "Arithmetic";
            Console.WriteLine("###################################################################");
            Console.WriteLine("#");
            Console.WriteLine($"#  {notice1}");
            Console.WriteLine("#");
            Console.WriteLine("###################################################################");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            var x = 1; // while value is a static 32-bit integer (int32), it can be manipulated after this simply using x = 1 etc. (must be within initial 16/32/64)

            var sum = 32 + 10; // addition

            var diff = 52 - 10; // subtraction

            var prod = 21 * 2; // multiplication

            var quot = 168 / 4; // division

            var mod = 42 % 5; // modulus








            // Increment-Decrement operations

          //  x++; // adds 1 to X, does not require value to X

          //  ++x; // adds 1 to X, after X's value has been determined

          //  x--; // subtracts 1 from X, does not require value to X

          //  --x; // subtract 1 from X, after X's value has been determined


            // Assignment and Lambda expressions

          //  x += 42; // increment. Add the value of y to the value of x, store the result in x, and return the new value.

          //  x -= 42; // decrement. Subtract the value of y from the value of x, store the result in x, and return the new value. 

          //  x *= 42; // multiplication assignment. Multiply the value of y to the value of x, store the result in x, and return the new value.

          //  x /= 42; // division assignment. Divide the value of x by the value of y, store the result in x, and return the new value.

          // x %= y;  // modulus assignment. Divide the value of x by the value of y, store the remainder in x, and return the new value.

          // x &= y; // AND assignment. AND the value of y with the value of x, store the result in x, and return the new value.

          // x |= y; // OR assignment. OR the value of y with the value of x, store the result in x, and return the new value.

          // x ^= y; // XOR assignment. XOR the value of y with the value of x, store the result in x, and return the new value.

          // x <<= y; // left-shift assignment.Shift the value of x left by y places, store the result in x, and return the new value.

          // x >>= y; // right - shift assignment.Shift the value of x right by y places, store the result in x, and return the new value.

            =>; // lambda declaration.


            // Comparative functions

            var eq = 10 == 5; // equal

            var ne = 10 != 5; // not equal

            var gt = 10 > 5; // greater than

            var lt = 10 < 5; // less than

            var gte = 10 >= 5; // greater-than or equal

            var lte = 10 <= 5; // less-than or equal




            var condition1 = true; //

            var condition2 = false; //

            var condition3 = false; //


            var both = condition1 && condition2; // cond1 and cond2 must be the same value

            var either = condition1 || condition2; // cond1 and cond2 must be 

            var oneOf = condition1 ^ condition2; // cond1 and cond2 must be different values



            Console.ReadLine();
        
        }
    }
}
