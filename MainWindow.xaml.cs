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

namespace Practic4pav
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int unit = int.Parse(vod.Text);
            double weight = int.Parse(vod2.Text);

            double kilograms;
            switch (unit)
            {
                case 1:
                    kilograms = weight;
                    break;
                case 2:
                    kilograms = weight / 1000000;
                    break;
                case 3:
                    kilograms = weight / 1000;
                    break;
                case 4:
                    kilograms = weight * 1000;
                    break;
                case 5:
                    kilograms = weight * 100;
                    break;
                default:
                    kilograms = 0;
                    break;
            }

            otv.Text = ("Масса тела в килограммах: " + kilograms);
        }
    }
}

