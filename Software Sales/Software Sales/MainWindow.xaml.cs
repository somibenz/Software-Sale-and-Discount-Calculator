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

namespace Software_Sales
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int quantity;
        const int price=99;
        int subtotal;
        double subtotal1;
        double subtotal2;
        double subtotal3;
        double subtotal4;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            quantity = int.Parse(textBox.Text);
            subtotal = quantity * 99;
            subtotal1 = subtotal * 0.2;
            subtotal2 = subtotal * 0.3;
            subtotal3 = subtotal * 0.4;
            subtotal4 = subtotal * 0.5;





            if (quantity <=9) {
                MessageBox.Show("You pay 99");
            }
            if (quantity>=10 && quantity <= 19)
            {   
                label.Content = subtotal - subtotal1;
             
            }
            if(quantity>=20 && quantity <= 49)
            {
                label.Content = subtotal - subtotal2;
            }
            if (quantity>=50 && quantity <= 99)
            {
                label.Content = subtotal - subtotal3;
            }
            if(quantity >= 100)
            {
                label.Content = subtotal - subtotal4;
            }
        }
    }
}
