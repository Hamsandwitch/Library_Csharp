using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetItTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string notice1 = "Everyone likes Star Wars! :D ";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("Press any key for the magic.");
            Console.ReadKey();
            Console.Clear();

            var thisDatetime = DateTime.Now.AddYears(-18).ToString("yyyy-MM-dd h:mm");

            var dateTimeNow = DateTime.Now;
            var today = DateTime.Today;
            var thisMonth = DateTime.Now.Month;
            var thisYear = DateTime.Now.Year;
            var startThisMonth = Convert.ToDateTime(thisYear + "/" + thisMonth + "/" + dateTimeNow.Day);

            var TestingTesting = "Completed on: " + DateTime.Now.DayOfWeek + " " + DateTime.Now;
            

            Console.WriteLine(TestingTesting);
            Console.ReadLine();
        }
    }
}
