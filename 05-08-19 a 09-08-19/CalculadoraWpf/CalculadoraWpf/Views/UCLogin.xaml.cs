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

namespace CalculadoraWpf.Views
{
    /// <summary>
    /// Interaction logic for UCLogin.xaml
    /// </summary>
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        public event EventHandler loginCorrect;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Teste(tbxLogin.Text, tbxSenha.Text);
        }

        public void Teste(string login, string senha)
        {
            if (login == "admin" && senha == "admin")
            {
                this.Visibility = Visibility.Hidden;
                loginCorrect(null, new EventArgs());
            }
            else
                MessageBox.Show("Gabriel Moscão");
        }

     
    }
}
