using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Recursion
    {
        DateTime _dateOfBirth;

        public void StartPoint()
        {
            RecursionCalculate();
        }

        private int EnterDate()
        {
            string dateValue = "";
            do
            {
                dateValue = Console.ReadLine();
                if (string.IsNullOrEmpty(dateValue))
                {
                    Console.Write("Repeat please: ");
                }

            } while (string.IsNullOrEmpty(dateValue));

            return int.Parse(dateValue);
        }

        private void RecursionCalculate()
        {
            int day = 0;
            int mounth = 0;
            int year = 0;

            Console.WriteLine("Enter your date of birth!");

            Console.Write("Enter day birth: ");
            day = EnterDate();


            Console.Write("Enter mounth birth: ");
            mounth = EnterDate();

            Console.Write("Enter year birth: ");
            year = EnterDate();


            if (year > DateTime.Now.Year)
            {
                Console.WriteLine("Incorrectly entered year value");
                RecursionCalculate();
            }
            else if (mounth > 12)
            {
                Console.WriteLine("Incorrectly entered mounth value");
                RecursionCalculate();

            }
            else if(day > DateTime.DaysInMonth(year, mounth))
            {
                Console.WriteLine("Incorrectly entered day value");
                RecursionCalculate();
            }

            _dateOfBirth = new DateTime(year, mounth, day);
            //_dateOfBirth.AddMonths(mounth);
            //_dateOfBirth.AddYears(year);

            Console.WriteLine(_dateOfBirth.ToString("dd - MM - yyyy"));
        }
    }
}
