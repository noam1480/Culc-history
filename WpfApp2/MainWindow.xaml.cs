using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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
        private void CreateBorder(int num1, int num2, double answer,char ch)
        {
            Border border = new Border();
            border.BorderThickness = new Thickness(1);
            border.BorderBrush = Brushes.Black;

            StackPanel panel = new StackPanel();

            TextBlock number1 = new TextBlock();
            number1.Text = num1.ToString();

            TextBlock op = new TextBlock();
            op.Text = ch.ToString();

            TextBlock number2 = new TextBlock();
            number2.Text = num2.ToString();

            TextBlock result = new TextBlock();
            result.Text = answer.ToString();

            panel.Children.Add(number1);
            panel.Children.Add(op);
            panel.Children.Add(number2);
            panel.Children.Add(result);

            border.Child = panel;
            history.Children.Add(border);
        }
        private void Plus(object sender, RoutedEventArgs e)
        {
            answer.Text= (double.Parse(Num1.Text)+(double.Parse(Num2.Text))).ToString();
            CreateBorder(int.Parse(Num1.Text), int.Parse(Num2.Text), double.Parse(answer.Text), '+');
        }
        private void Minos(object sender, RoutedEventArgs e)
        {
            answer.Text= (double.Parse(Num1.Text)-(double.Parse(Num2.Text))).ToString();
            CreateBorder(int.Parse(Num1.Text), int.Parse(Num2.Text), double.Parse(answer.Text), '-');
        }
        private void Devaid(object sender, RoutedEventArgs e)
        {
            answer.Text= (double.Parse(Num1.Text)/(double.Parse(Num2.Text))).ToString();
            CreateBorder(int.Parse(Num1.Text), int.Parse(Num2.Text), double.Parse(answer.Text), '/');
        }
        private void Multy(object sender, RoutedEventArgs e)
        {
            answer.Text= (double.Parse(Num1.Text)*(double.Parse(Num2.Text))).ToString();
            CreateBorder(int.Parse(Num1.Text), int.Parse(Num2.Text), double.Parse(answer.Text), '*');
        }
    }
}
