using MVCProject.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarGenero frmAdd = new frmAdicionarGenero();
            frmAdd.ShowDialog();

            this.generosTableAdapter.Insert(
                frmAdd.generoRow.Tipo,
                frmAdd.generoRow.Descricao
                );
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);
        }
    }
}
