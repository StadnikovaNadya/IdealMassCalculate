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

namespace IdealMassCalculate
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

        double DevineMetod(double height, string gender)
        {
            double answer = 0.0;
            switch(gender)
            {
                case "Мужской":
                    answer = 50 + 2.3 * (0.394 * height - 60);

                    break;
                case "Женский":
                    answer = 45.5 + 2.3 * (0.395 * height - 60);

                    break;

                default:
                    MessageBox.Show("Укажите пол");
                    break;


            }
            return answer;
        }
        double RobinsonMetod(double height, string gender)
        {
            double answer = 0.0;
            switch (gender)
            {
                case "Мужской":
                    answer = 52 + 1.9 * (0.394 * height - 60);

                    break;
                case "Женский":
                    answer = 49 + 1.7 * (0.395 * height - 60);

                    break;

                default:
                    MessageBox.Show("Укажите пол");
                    break;


            }
            return answer;
        }




        private void btCalc_Click(object sender, RoutedEventArgs e)
        {
            double hg=0.0;
            try
            {
                 hg = Convert.ToDouble(tbHeight.Text);
            }
             catch (Exception error)
            {
                MessageBox.Show($"Произошла ошибка, обратитесь к админестратору: {error.Message}");
            }
            
            switch(cbMethood.Text)
            {
                case "Devine":
                    
                    lbIMT.Content = $"Ваш ИМТ:{DevineMetod(hg, cbGender.Text)}";
                    break;
                case "Robinson":
                    
                    lbIMT.Content = $"Ваш ИМТ:{RobinsonMetod(hg, cbGender.Text)}";
                    break;
                default:
                    MessageBox.Show("Выберете метод");
                    break;
            }
        }
    }
}
