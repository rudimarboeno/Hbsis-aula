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
using WpfAppEntity.Data;

namespace WpfAppEntity.Views
{
    /// <summary>
    /// Interaction logic for usGridView.xaml
    /// </summary>
    public partial class usGridView : UserControl
    {
        public usGridView()
        {
            InitializeComponent();
        }

        public BibliotecaDBContext context = new BibliotecaDBContext();

        private void DtGridView_Loaded(object sender, RoutedEventArgs e)
        {
            dtGridView.ItemsSource = context.Usuarios.ToList<Usuario>();
        }

        private void DtGridView_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var objectEdit = ((DataGrid)sender).SelectedValue as Usuario;

            
            
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();

            MessageBox.Show("Carregando...");
            MessageBox.Show("Atualizado com sucesso!");

        }
    }
}
