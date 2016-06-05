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

namespace Task1
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

        private void btAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(RandomNumber() == int.Parse(tbNumber.Text))
                {
                    MessageBox.Show("Congratulations! You have WON");
                }
                else
                {
                    MessageBox.Show("Failure, try again:(");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong data!");
            }

        }

        private int RandomNumber()
        {
            Random rand = new Random();
            return rand.Next(1, 11);
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
