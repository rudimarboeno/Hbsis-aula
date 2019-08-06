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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarLocacao formAdd = new frmAdicionarLocacao();
            formAdd.ShowDialog();

            this.locacaoTableAdapter.Insert(
                formAdd.locacaoRow.Livro,
                formAdd.locacaoRow.Usuario,
                formAdd.locacaoRow.Tipo,
                DateTime.Now,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
        }
    }
}
