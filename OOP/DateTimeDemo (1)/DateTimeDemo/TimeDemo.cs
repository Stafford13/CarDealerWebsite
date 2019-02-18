using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    public class TimeDemo
    {
        public static void Run()
        {
            // Displaying current Date
            DateTime dt = DateTime.Now;
            Thread.Sleep(3000);
            Console.WriteLine(dt);
            // Creating a date in a time known
            DateTime dt2 = new DateTime(2019, 1, 29, 9, 40, 0);
            // Modify time itself!
            dt2 = dt2.AddHours(2);
            dt2 = dt2.AddMinutes(-40);
            Console.WriteLine(dt2);
            // calcuating difference between two dates
            TimeSpan diff = dt2 - dt;
            Console.WriteLine(diff.ToString("g"));

            // parse date from user
            string userInput = "1/29/2019 11:30 AM";
            DateTime dt3 = new DateTime();
            DateTime.TryParse(userInput, out dt3);
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "MM/dd/yy HH:mm";
            if (!DateTime.TryParse(Console.ReadLine(), out dt3))
            {
                Console.WriteLine("Invalid format");
            }

            if (!DateTime.TryParseExact(userInput, format, provider, DateTimeStyles.None, out dt3))
            {
                Console.WriteLine("{0} !!! Invalid format {0}", format);

            }

            Console.WriteLine(dt3);
            // format date by format given
            string format2 = "MM-dd-yy HH:mm:ss";

            Console.WriteLine(dt.ToString(format));
            Console.WriteLine(dt.ToString(format2));
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToLongDateString());

            Console.ReadLine();
        }
    }
}
