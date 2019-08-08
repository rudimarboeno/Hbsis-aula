using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace FormWpf
{
    /// <summary>
    /// Interaction logic for FormValidacoes.xaml
    /// </summary>
    public partial class FormValidacoes : UserControl
    {
        public FormValidacoes()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string telefone = tbxTelefone.Text;

            string email = tbxEmail.Text;

            var stringRegEmail = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";

            var stringRegTelefone = "^\\+(?:[0-9] ?){6,14}[0-9]$";

            Regex regexEmail = new Regex(stringRegEmail);

            Regex regexTelefone = new Regex(stringRegTelefone);

            var matchEmail = regexEmail.IsMatch(email);

            var matchPhone = regexTelefone.IsMatch(telefone);

            if (matchPhone)
                MessageBox.Show("Telefone valido");

            else
                MessageBox.Show("Telefone invalido");

            if (matchEmail)
                MessageBox.Show("Email Valido");
            else
                MessageBox.Show("Email invalido");

         

        }



    }
}
