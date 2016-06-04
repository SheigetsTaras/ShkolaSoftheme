using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            btReg.IsEnabled = false;
        }

        private void btCheck_Click(object sender, RoutedEventArgs e)
        {
            CheckFields checkFields = new CheckFields();
            if (checkFields.CheckField(tbFirstName.Text, tbLastName.Text, tbBirth.Text, tbEmail.Text, tbPhone.Text, tbAdditional.Text))
                btReg.IsEnabled = true;

        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btReg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Registration completed successfully");
            this.Close();
        }
    }
}
    