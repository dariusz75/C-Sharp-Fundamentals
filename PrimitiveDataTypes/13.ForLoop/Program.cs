using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ForLoop
{
    class Program
    {
        static void Main()
        {
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int daysInMonth = 31;

            for (int month = 0; month < months.Length; month++)
            {
                Console.WriteLine(months[month]);

                for (int day = 1; day <= daysInMonth; day++)
                {
                    Console.WriteLine(day);
                    if (month == 1 && day == 28)
                    {
                        break;
                    }
                    else if (month == 3 && day == 30)
                    {
                        break;
                    }
                    else if (month == 5 && day == 30)
                    {
                        break;
                    }
                    else if (month == 8 && day == 30)
                    {
                        break;
                    }
                    else if (month == 10 && day == 30)
                    {
                        break;
                    }
                }
            }

        }
    }
}
