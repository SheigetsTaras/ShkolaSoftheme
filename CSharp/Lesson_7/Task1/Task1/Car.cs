using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Car
    {
        private string model = "Dodge";
        private int year = 1969;
        private string color = "Blue";


        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public void Show()
        {
            Console.Write("Car\n" + "Model: " + model + " \nYear: " + year + " \nColor: ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Color);
            Console.ResetColor();

            Car car = new Car();
            Console.Write("Color after painting: ");
            TuningAtelier.TuneCar(car);
        }
    }


    public static class TuningAtelier
    {
        public static void TuneCar(Car car)
        {
            car.Color = "DarkYellow";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(car.Color);
            Console.ResetColor();
        }
    }
}
