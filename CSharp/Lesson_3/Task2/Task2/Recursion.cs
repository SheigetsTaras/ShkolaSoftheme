using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Recursion
    {
        DateTime _dateOfBirth;
        MainWindow mainWindow = new MainWindow();

        public void StartPoint(int day, int mounth, int year)
        {
            RecursionCalculate(day, mounth, year);
        }

        private int EnterDate()
        {
            string dateValue = "";
            int intDateValue = 0;

            do
            {
                try
                {
                    if (string.IsNullOrEmpty(dateValue))
                    {
                        mainWindow.label6.Content = "Repeat please: ";
                    }

                    intDateValue = int.Parse(dateValue);
                }
                catch (Exception)
                {
                    mainWindow.label6.Content = "Must be a number";
                }

            } while (intDateValue == 0);

            return intDateValue;
        }

        private void RecursionCalculate(int day, int mounth, int year)
        {
            //day = int.Parse(mainWindow.textBox.Text);
           // day = EnterDate();

           // mounth = int.Parse(mainWindow.textBox1.Text);
         //   mounth = EnterDate();

           // year = int.Parse(mainWindow.textBox2.Text);
         //   year = EnterDate();

            if (year > DateTime.Now.Year)
            {
                mainWindow.label6.Content = "Incorrectly entered year value";
                RecursionCalculate(day, mounth, year);
            }
            else if (mounth > 12)
            {
                mainWindow.label6.Content = "Incorrectly entered mounth value";
                RecursionCalculate(day, mounth, year);

            }
            else if (day > DateTime.DaysInMonth(year, mounth))
            {
                mainWindow.label6.Content = "Incorrectly entered day value";
                RecursionCalculate(day, mounth, year);
            }

            _dateOfBirth = new DateTime(year, mounth, day);

            //mainWindow.label3.Content = (_dateOfBirth.ToString("dd - MM - yyyy").ToString());
            //ShowDate(_dateOfBirth);

            AgeCalculate();
            ZodiacSingCalculate();
        }

        private void ZodiacSingCalculate()
        {
            if (_dateOfBirth.Month == 1 && _dateOfBirth.Day >= 20 || _dateOfBirth.Month == 2 && _dateOfBirth.Day <= 18)
                mainWindow.label5.Content = ("Zodiac Sign is Aquarius");

            else if (_dateOfBirth.Month == 2 && _dateOfBirth.Day >= 19 || _dateOfBirth.Month == 3 && _dateOfBirth.Day <= 20)
                mainWindow.label5.Content = ("Zodiac Sign is Pisces");

            else if (_dateOfBirth.Month == 3 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 4 && _dateOfBirth.Day <= 19)
                mainWindow.label5.Content = ("Zodiac Sign is Aries");

            else if (_dateOfBirth.Month == 4 && _dateOfBirth.Day >= 20 || _dateOfBirth.Month == 5 && _dateOfBirth.Day <= 20)
                mainWindow.label5.Content = ("Zodiac Sign is Taurus");

            else if (_dateOfBirth.Month == 5 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 6 && _dateOfBirth.Day <= 20)
                mainWindow.label5.Content = ("Zodiac Sign is Gemini");

            else if (_dateOfBirth.Month == 6 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 7 && _dateOfBirth.Day <= 22)
                mainWindow.label5.Content = ("Zodiac Sign is Cancer");

            else if (_dateOfBirth.Month == 7 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 8 && _dateOfBirth.Day <= 22)
                mainWindow.label5.Content = ("Zodiac Sign is Leo");

            else if (_dateOfBirth.Month == 8 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 9 && _dateOfBirth.Day <= 22)
                mainWindow.label5.Content = ("Zodiac Sign is Virgo");

            else if (_dateOfBirth.Month == 9 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 10 && _dateOfBirth.Day <= 22)
                mainWindow.label5.Content = ("Zodiac Sign is Libra");

            else if (_dateOfBirth.Month == 10 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 11 && _dateOfBirth.Day <= 22)
                mainWindow.label5.Content = ("Zodiac Sign is Scorpio");

            else if (_dateOfBirth.Month == 11 && _dateOfBirth.Day >= 22 || _dateOfBirth.Month == 12 && _dateOfBirth.Day <= 21)
                mainWindow.label5.Content = ("Zodiac Sign is Sagittarius");

            else if (_dateOfBirth.Month == 12 && _dateOfBirth.Day >= 22 || _dateOfBirth.Month == 1 && _dateOfBirth.Day <= 19)
                mainWindow.label5.Content = ("Zodiac Sign is Capricorn");
        }

        private void AgeCalculate()
        {
            TimeSpan age = DateTime.Now - _dateOfBirth;

            if (DateTime.IsLeapYear(_dateOfBirth.Year))
                mainWindow.label4.Content = (age.Days / 366);
            else
                mainWindow.label4.Content = (age.Days / 366);
        }
    }
}
