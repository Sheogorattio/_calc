using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _calc
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

        private void Button_Click(object sender, RoutedEventArgs e)//clean all
        {
            ExpressionTextBox.Text = null;
            ResultTextBox.Text = null;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//clean entry
        {
            ExpressionTextBox.Text = null;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//get result
        {
            DataTable obj = new DataTable();
            char[] oprations = { '+', '-', '/', '*' };
            if(ExpressionTextBox.Text.Length > 0)
            {
                foreach (char _opeartor in oprations)
                {
                    if (_opeartor == ExpressionTextBox.Text[ExpressionTextBox.Text.Length - 1]) return;
                }
            }
            ResultTextBox.Text = obj.Compute(ExpressionTextBox.Text, " ").ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//operation handler
        {
            char[] oprations = { '+', '-', '/', '*' };
            if (ExpressionTextBox.Text.Length > 0)
            {
                foreach (char _opeartor in oprations)
                {
                    if (_opeartor == ExpressionTextBox.Text[ExpressionTextBox.Text.Length - 1]) return;
                }
            }
            else if ((sender as Button).Content.ToString() != "-") return;
            ExpressionTextBox.Text = ExpressionTextBox.Text + (sender as Button).Content.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)//digits handler
        {
            ExpressionTextBox.Text = ExpressionTextBox.Text + (sender as Button).Content.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)//dot press handler
        {
            if (ExpressionTextBox.Text[ExpressionTextBox.Text.Length - 1] >= '0' &&
                ExpressionTextBox.Text[ExpressionTextBox.Text.Length - 1] <= '9'
                && ExpressionTextBox.Text != "")
            {
                ExpressionTextBox.Text = ExpressionTextBox.Text + (sender as Button).Content.ToString();
            }
        }
    }
}
