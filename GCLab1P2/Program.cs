using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab1P2
{

    class Program
    {

        static DateTime DateGet()
        {

            DateTime output = DateTime.Now;

            string inDate = Console.ReadLine();

            bool whileBreak = false;

            while (whileBreak == false)
            {

                bool tryAgain = false;

                try
                {

                    output = Convert.ToDateTime(inDate);

                }
                catch (FormatException e)
                {

                    Console.WriteLine("Did you use the correct Month/Day/Year format?");
                    Console.WriteLine("Please try again.");
                    inDate = Console.ReadLine();
                    whileBreak = false;
                    tryAgain = true;

                }
                catch (OverflowException e)
                {

                    Console.WriteLine("Quite impressive, making an overflow error.");
                    Console.WriteLine("Please try again.");
                    inDate = Console.ReadLine();
                    whileBreak = false;
                    tryAgain = true;

                }
                finally
                {

                    if (tryAgain != true)
                    {

                        whileBreak = true;

                    }

                }

            }

            

            return output;

        }

        static int DateDifference(DateTime first, DateTime last)
        {

            int days = 0;
            int d1 = Convert.ToInt32(first);
            int d2 = Convert.ToInt32(last);

            days = Math.Abs((d1 - d2));

            return days;

        }

        static void Main(string[] args)
        {

            DateTime startDate;
            DateTime endDate;

            Console.WriteLine("Hello, please enter two dates in the following format: MM/dd/yyyy");

            Console.WriteLine("Please enter the first date.");

            startDate = DateGet();

            Console.WriteLine("Please enter the second date.");

            endDate = DateGet();

            int dayDifference = (endDate - startDate).Days;

            dayDifference = Math.Abs(dayDifference);

            Console.WriteLine("The two dates are " + dayDifference + " days apart.");
            Console.WriteLine("(" + (dayDifference * 24) + " hours; " + (dayDifference * 24 * 60) + " minutes)");

            Console.ReadKey();

        }

    }

}
