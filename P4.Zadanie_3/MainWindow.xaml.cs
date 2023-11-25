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

namespace P4.Zadanie_3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(Box1.Text, out double number))
            { MessageBox.Show("Поле только для чисел"); }
            if (!double.TryParse(Box2.Text, out double znachenie))
            { MessageBox.Show("Поле только для чисел"); }
            double R;
            double D;
            double L;
            double S;
            switch (number)
            {
                case 1:
                     R = znachenie; D = 2 * R; L = 2 * 3.14 * R; S = 3.14 * R * R;
                    break;
                case 2:
                     D = znachenie; R = D / 2; L = 2 * 3.14 * R; S = 3.14 * R * R;
                    break;
                case 3:
                     L = znachenie; R = L / (2 * 3.14); D = 2 * R; S = 3.14 * R * R;
                    break;
                case 4:
                     S = znachenie; R = Math.Sqrt(S / 3.14); D = 2 * R; L = 2 * 3.14 * R;
                    break;
                case 5:
                    Answer.Text += "Некорректный номер элемента";
                    break;
                    Answer.Text += R + L + S + D;
                    break;
            }
        }
    }
}
