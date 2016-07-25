using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combined_Util_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}


using System;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Part One

string a1 = "This is a string"; // 1
bool b2 = true;
int c3 = 126;
double d4 = 2.86;
decimal e5 = 1.43m;

Console.WriteLine("### TYPE CONVERSION ###");
string BuildString(int integer, double doub) // 2
{
    return $"Heres the combination results... {integer} and {doub}!";
}
var result = BuildString(c3, d4);
Console.WriteLine(result); // 3

var theArray = new string[7]; // 4 
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

Console.WriteLine("### Results 2 ###");
for (int y = 0; y<theArray.Length; y++)
{
    Console.WriteLine(theArray[y]);