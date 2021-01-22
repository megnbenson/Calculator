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
using CalculatorLib;



namespace WPFcoreCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int count = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, you clicked??");
        }

        private void LeftNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            //LeftNameOutputLabel.Content = $"{LeftNum.Text}";
        }

        private void RightNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            //RightNameOutputLabel.Content = $"{RightNum.Text}";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(Int32.TryParse(LeftNum.Text, out int first) && Int32.TryParse(RightNum.Text, out int second))
            {
                EqualsLabel.FontSize = 100;

                // Take 
                int firstNum = Int32.Parse(LeftNum.Text);
                //Int16.Parse("100"); // returns 100
                int secondNum = Int32.Parse(RightNum.Text);


                var result = CalculatorLib.StaticCalculator.Add(firstNum, secondNum);
                EqualsLabel.Content = $"{result}";

                //Console.WriteLine(firstNum);
            }
            else
            {
                EqualsLabel.FontSize = 20;
                EqualsLabel.Content = "Re-Enter Numbers";
            }

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(LeftNum.Text, out int first) && Int32.TryParse(RightNum.Text, out int second))
            {
                EqualsLabel.FontSize = 100;
                // Take 
                int firstNum = Int32.Parse(LeftNum.Text);
                //Int16.Parse("100"); // returns 100
                int secondNum = Int32.Parse(RightNum.Text);


                var result = CalculatorLib.StaticCalculator.Subtract(firstNum, secondNum);
                EqualsLabel.Content = $"{result}";
            }
            else
            {
                EqualsLabel.FontSize = 20;
                EqualsLabel.Content = "Re-Enter Numbers";
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(LeftNum.Text, out int first) && Int32.TryParse(RightNum.Text, out int second))
            {
                EqualsLabel.FontSize = 100;

                // Take 
                int firstNum = Int32.Parse(LeftNum.Text);
                //Int16.Parse("100"); // returns 100
                int secondNum = Int32.Parse(RightNum.Text);


                var result = CalculatorLib.StaticCalculator.Divide(firstNum, secondNum);
                EqualsLabel.Content = $"{result}";
            }
            else
            {
                EqualsLabel.FontSize = 20;
                EqualsLabel.Content = "Re-Enter Numbers";
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(LeftNum.Text, out int first) && Int32.TryParse(RightNum.Text, out int second))
            {
                EqualsLabel.FontSize = 100;

                // Take 
                int firstNum = Int32.Parse(LeftNum.Text);
                //Int16.Parse("100"); // returns 100
                int secondNum = Int32.Parse(RightNum.Text);


                var result = CalculatorLib.StaticCalculator.Multiply(firstNum, secondNum);
                EqualsLabel.Content = $"{result}";
            }
            else
            {
                EqualsLabel.FontSize = 20;
                EqualsLabel.Content = "Re-Enter Numbers";
            }
        }

        private void Modulus_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(LeftNum.Text, out int first) && Int32.TryParse(RightNum.Text, out int second))
            {
                EqualsLabel.FontSize = 100;

                // Take 
                int firstNum = Int32.Parse(LeftNum.Text);
                //Int16.Parse("100"); // returns 100
                int secondNum = Int32.Parse(RightNum.Text);


                var result = CalculatorLib.StaticCalculator.Modulus(firstNum, secondNum);
                EqualsLabel.Content = $"{result}";
            }
            else
            {
                EqualsLabel.FontSize = 20;
                EqualsLabel.Content = "Re-Enter Numbers";
            }
        }
    }
}

