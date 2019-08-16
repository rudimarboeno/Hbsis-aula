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

namespace CalculadoraWpf.Views
{
    /// <summary>
    /// Interaction logic for UcCalculos.xaml
    /// </summary>
    public partial class UcCalculos : UserControl
    {
        public UcCalculos()
        {
            InitializeComponent();
        }

   

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            //Botão 1
            Button x = (Button)sender;
            display.Text += x.Content;
           
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            //Botão 0
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_Virgula(object sender, RoutedEventArgs e)
        {
            //Botão Virgula
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Botão numero 2
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //Botão numero 3
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            //Botão  =
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Botão +
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //Botão  -
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //Botão  *
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //Botão  /
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            //Botão apaga 
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            //Botão apaga tudo
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            //Botão numero 7
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            //Botão numero 4
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            //Botão numero 5
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            //Botão c
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            //Botão numero 8
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            //Botão numero 9
            Button x = (Button)sender;
            display.Text += x.Content;
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            //Botão numero 6
            Button x = (Button)sender;
            display.Text += x.Content;
        }
    }
}
