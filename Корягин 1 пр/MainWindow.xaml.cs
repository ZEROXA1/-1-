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
using LIB;
namespace Корягин_1_пр
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void О_Программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Корягин Максим ИСП-34. Практическая работа №1. \r\nСгенерировать массив заполненный случайными вещественными числами, распределенных в диапазоне от -5 до 4. Вычислить для чисел > 0 извлечь корень , а для чисел < 0 возвести в квадрат. На экран необходимо выводить сгенерированные числа и результат расчета функции на разных строках. В классе реализовать статический метод с именем SignSquare");
        }

        private void Вычислить_Click(object sender, RoutedEventArgs e)
        {
            bool q = Int32.TryParse(ItemCount.Text, out int itemCount);
            if (!q)
            {
                MessageBox.Show("Данные введены неверно");
            }
            else
            {
                double[] array = MathString.Array(itemCount);
                OutArray.Text = String.Join("\r\n", array);
                MathString.SignSquare(array, out string outSqrt, out string outPow);
                OutSqrt.Text = outSqrt;
                OutPow.Text = outPow;
            }
        }
    }
}
