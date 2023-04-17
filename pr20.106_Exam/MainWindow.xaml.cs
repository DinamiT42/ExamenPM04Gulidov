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

namespace pr20._106_Exam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtboxOrganiz.Text.Length < 10 || txtboxOrganiz.Text.Length > 50)
            {
                txtboxOrganiz.Background = Brushes.Red;
                string text = "Минимум 10 символов";
                textBlockOrganiz.Text = text;

            }
            else
            {
                txtboxOrganiz.Background = Brushes.Green;
                string text1 = "норм";
                textBlockOrganiz.Text = text1;
            }

        }

        private void textBoxminus_PreviewTextInput(object sender, TextCompositionEventArgs e) // Отрицательное знач
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1) || (textBoxminus.Text == "" && e.Text == "-"))
            {
                e.Handled = true;
            }
        }

        private void txtboxPoz_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtboxPoz.Text.Length < 2 || txtboxPoz.Text.Length > 30)
            {
                txtboxPoz.Background = Brushes.Red;
                string text2 = "минимум 2 символа";
                textBlockPoz.Text = text2;

            }
            else
            {
                txtboxPoz.Background = Brushes.Green;
                string text3 = "сойдет";
                textBlockPoz.Text = text3;
            }
        }

       
    }
}
