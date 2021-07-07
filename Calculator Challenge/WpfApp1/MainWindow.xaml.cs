﻿using System;
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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 + number2;

            label.Content = total;

        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 - number2;

            label.Content = total;
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 * number2;

            label.Content = total;
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 / number2;

            label.Content = total;
        }

        private void Modulus_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox1.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 % number2;

            label.Content = total;
        }
    }
}
