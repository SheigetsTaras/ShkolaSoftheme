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

namespace _1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (listBox.SelectedItem as ListBoxItem);

            switch (selectedItem.Content.ToString())
            {
                case "int":
                    PrintInt();
                    break;

                case "Double":
                    PrintDouble();
                    break;

                case "Float":
                    PrintFloat();
                    break;

                case "Byte":
                    PrintByte();
                    break;

                case "Decimal":
                    PrintDecimal();
                    break;

                case "long":
                    PrintLong();
                    break;

                case "sbyte":
                    PrintSbyte();
                    break;

                case "short":
                    PrintUshort();
                    break;

                case "ulong":
                    PrintUlong();
                    break;

                case "uint":
                    PrintUint();
                    break;

                case "ushort":
                    PrintUshort();
                    break;
            }
        }

        private void PrintInt()
        {
            int i = 45;

            textBoxMinValue.Text = int.MinValue.ToString();
            textBoxValue.Text = i.ToString();
            textBoxMaxValue.Text = int.MaxValue.ToString();
        }

        private void PrintDouble()
        {
            double d = 45;

            textBoxMinValue.Text = double.MinValue.ToString();
            textBoxValue.Text = d.ToString();
            textBoxMaxValue.Text = double.MaxValue.ToString();
        }

        private void PrintFloat()
        {
            int f = 45;

            textBoxMinValue.Text = float.MinValue.ToString();
            textBoxValue.Text = f.ToString();
            textBoxMaxValue.Text = float.MaxValue.ToString();
        }

        private void PrintByte()
        {
            byte b = 45;

            textBoxMinValue.Text = byte.MinValue.ToString();
            textBoxValue.Text = b.ToString();
            textBoxMaxValue.Text = byte.MaxValue.ToString();
        }

        private void PrintDecimal()
        {
            decimal d = 45;

            textBoxMinValue.Text = decimal.MinValue.ToString();
            textBoxValue.Text = d.ToString();
            textBoxMaxValue.Text = decimal.MaxValue.ToString();
        }

        private void PrintLong()
        {
            long l = 45;

            textBoxMinValue.Text = long.MinValue.ToString();
            textBoxValue.Text = l.ToString();
            textBoxMaxValue.Text = long.MaxValue.ToString();
        }

        private void PrintSbyte()
        {
            sbyte sB = 45;

            textBoxMinValue.Text = sbyte.MinValue.ToString();
            textBoxValue.Text = sB.ToString();
            textBoxMaxValue.Text = sbyte.MaxValue.ToString();
        }

        private void PrintShort()
        {
            short s = 45;

            textBoxMinValue.Text = short.MinValue.ToString();
            textBoxValue.Text = s.ToString();
            textBoxMaxValue.Text = short.MaxValue.ToString();
        }

        private void PrintUlong()
        {
            ulong uL= 45;

            textBoxMinValue.Text = ulong.MinValue.ToString();
            textBoxValue.Text = uL.ToString();
            textBoxMaxValue.Text = ulong.MaxValue.ToString();
        }

        private void PrintUint()
        {
            uint uI= 45;

            textBoxMinValue.Text = uint.MinValue.ToString();
            textBoxValue.Text = uI.ToString();
            textBoxMaxValue.Text = uint.MaxValue.ToString();
        }

        private void PrintUshort()
        {
            ushort uS = 45;

            textBoxMinValue.Text = ushort.MinValue.ToString();
            textBoxValue.Text = uS.ToString();
            textBoxMaxValue.Text = ushort.MaxValue.ToString();
        }


    }
}
