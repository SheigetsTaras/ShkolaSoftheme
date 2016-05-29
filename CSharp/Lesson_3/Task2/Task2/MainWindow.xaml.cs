using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2
{

    public partial class MainWindow : Window
    {
        DateTime _dateOfBirth;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (EnterDate(textBox.Text) == true && EnterDate(textBox1.Text) == true && EnterDate(textBox2.Text) == true)
            {
                RecursionCalculate();
                label6.Content = "";
            }
        }

        private bool EnterDate(string dateValue)
        {
            int intDateValue = 0;

                try
                {
                    if (string.IsNullOrEmpty(dateValue))
                    {
                        label6.Content = "Repeat please: ";
                    return false;
                    }

                    intDateValue = int.Parse(dateValue);
                }
                catch (Exception)
                {
                    label6.Content = "Must be a number";
                return false;
                }
            return true;
        }


        private void RecursionCalculate()
        {
            int day = int.Parse(textBox.Text);

            int mounth = int.Parse(textBox1.Text);

            int year = int.Parse(textBox2.Text);

            if (year == 0 || year > DateTime.Now.Year)
            {
                label6.Content = "Incorrectly entered year value";
                RecursionCalculate();
            }
            else if (mounth == 0 || mounth > 12)
            {
                label6.Content = "Incorrectly entered mounth value";
                RecursionCalculate();

            }
            else if (day > DateTime.DaysInMonth(year, mounth))
            {
                label6.Content = "Incorrectly entered day value";
                RecursionCalculate();
            }

            _dateOfBirth = new DateTime(year, mounth, day);

            label3.Content = (_dateOfBirth.ToString("dd - MM - yyyy").ToString());

            AgeCalculate();
            ZodiacSingCalculate();
        }

        private void ZodiacSingCalculate()
        {
            if (_dateOfBirth.Month == 1 && _dateOfBirth.Day >= 20 || _dateOfBirth.Month == 2 && _dateOfBirth.Day <= 18)
            {
                label5.Content = ("Zodiac Sign is Aquarius");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("aquarius.jpg"));
            }
            else if (_dateOfBirth.Month == 2 && _dateOfBirth.Day >= 19 || _dateOfBirth.Month == 3 && _dateOfBirth.Day <= 20)
            {
                label5.Content = ("Zodiac Sign is Pisces");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Pisces.jpg"));
            }

            else if (_dateOfBirth.Month == 3 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 4 && _dateOfBirth.Day <= 19)
            {
                label5.Content = ("Zodiac Sign is Aries");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Aries.jpg"));
            }

            else if (_dateOfBirth.Month == 4 && _dateOfBirth.Day >= 20 || _dateOfBirth.Month == 5 && _dateOfBirth.Day <= 20)
            {
                label5.Content = ("Zodiac Sign is Taurus");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Taurus.jpg"));
            }

            else if (_dateOfBirth.Month == 5 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 6 && _dateOfBirth.Day <= 20)
            {
                label5.Content = ("Zodiac Sign is Gemini");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Gemini.jpg"));
            }

            else if (_dateOfBirth.Month == 6 && _dateOfBirth.Day >= 21 || _dateOfBirth.Month == 7 && _dateOfBirth.Day <= 22)
            {
                label5.Content = ("Zodiac Sign is Cancer");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Cancer.jpg"));
            }

            else if (_dateOfBirth.Month == 7 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 8 && _dateOfBirth.Day <= 22)
            {
                label5.Content = ("Zodiac Sign is Leo");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Leo.jpg"));
            }

            else if (_dateOfBirth.Month == 8 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 9 && _dateOfBirth.Day <= 22)
            {
                label5.Content = ("Zodiac Sign is Virgo");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Virgo.jpg"));
            }

            else if (_dateOfBirth.Month == 9 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 10 && _dateOfBirth.Day <= 22)
            {
                label5.Content = ("Zodiac Sign is Libra");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Libra.jpg"));
            }

            else if (_dateOfBirth.Month == 10 && _dateOfBirth.Day >= 23 || _dateOfBirth.Month == 11 && _dateOfBirth.Day <= 22)
            {
                label5.Content = ("Zodiac Sign is Scorpio");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Scorpio.jpg"));
            }

            else if (_dateOfBirth.Month == 11 && _dateOfBirth.Day >= 22 || _dateOfBirth.Month == 12 && _dateOfBirth.Day <= 21)
            {
                label5.Content = ("Zodiac Sign is Sagittarius");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Sagittarius.jpg"));
            }

            else if (_dateOfBirth.Month == 12 && _dateOfBirth.Day >= 22 || _dateOfBirth.Month == 1 && _dateOfBirth.Day <= 19)
            {
                label5.Content = ("Zodiac Sign is Capricorn");
                ImageSourceConverter imgs = new ImageSourceConverter();
                image.SetValue(Image.SourceProperty, imgs.ConvertFromString("Capricorn.jpg"));
            }
        }

        private void AgeCalculate()
        {
            TimeSpan age = DateTime.Now - _dateOfBirth;

            if (DateTime.IsLeapYear(_dateOfBirth.Year))
                label4.Content = (age.Days / 366);
            else
                label4.Content = (age.Days / 366);
        }

    }
}
