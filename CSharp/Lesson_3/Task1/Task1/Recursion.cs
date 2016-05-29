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

            Console.WriteLine(_dateOfBirth.ToString("dd - MM - yyyy"));

            AgeCalculate();
            ZodiacSingCalculate();
        }

        private void ZodiacSingCalculate()
        {
            if (_dateOfBirth.Month == 1 && _dateOfBirth.Day >= 20 || _dateOfBirth.Month == 2 && _dateOfBirth.Day <= 18)
                Console.WriteLine("Zodiac Sign is Aquarius");
            if (_dateOfBirth.Month == 2 && _dateOfBirth.Day >= 19 || _dateOfBirth.Month == 3 && _dateOfBirth.Day <= 20)
                Console.WriteLine("Zodiac Sign is Pisces");
            if (_dateOfBirth.Month == 3 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 4 && _dateOfBirth.Day <= 19)
                Console.WriteLine("Zodiac Sign is Aries");
            if (_dateOfBirth.Month == 4 && _dateOfBirth.Day >= 20 || _dateOfBirth.Month == 5 && _dateOfBirth.Day <= 20)
                Console.WriteLine("Zodiac Sign is Taurus");
            if (_dateOfBirth.Month == 5 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 6 && _dateOfBirth.Day <= 20)
                Console.WriteLine("Zodiac Sign is Gemini");
            if (_dateOfBirth.Month == 6 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 7 && _dateOfBirth.Day <= 22)
                Console.WriteLine("Zodiac Sign is Cancer");
            if (_dateOfBirth.Month == 7 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 8 && _dateOfBirth.Day <= 22)
                Console.WriteLine("Zodiac Sign is Leo");
            if (_dateOfBirth.Month == 8 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 9 && _dateOfBirth.Day <= 22)
                Console.WriteLine("Zodiac Sign is Virgo");
            if (_dateOfBirth.Month == 9 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 10 && _dateOfBirth.Day <= 22)
                Console.WriteLine("Zodiac Sign is Libra");
            if (_dateOfBirth.Month == 10 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 11 && _dateOfBirth.Day <= 22)
                Console.WriteLine("Zodiac Sign is Scorpio");
            if (_dateOfBirth.Month == 11 && _dateOfBirth.Day >= 22 || _dateOfBirth.Month == 12 && _dateOfBirth.Day <= 21)
                Console.WriteLine("Zodiac Sign is Sagittarius");
            if (_dateOfBirth.Month == 12 && _dateOfBirth.Day >= 22 || _dateOfBirth.Month == 1 && _dateOfBirth.Day <= 19)
                Console.WriteLine("Zodiac Sign is Capricorn");
        }

        private void AgeCalculate()
        {
            TimeSpan age = DateTime.Now - _dateOfBirth;

            if (DateTime.IsLeapYear(_dateOfBirth.Year))
                Console.WriteLine(age.Days / 366);
            else
                Console.WriteLine(age.Days / 365);
        }
    }
}
