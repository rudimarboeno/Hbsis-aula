using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Adicionar
{
    public partial class frmAdicionarLocacao : Form
    {
        public frmAdicionarLocacao()
        {
            InitializeComponent();
        }
        public Locacao locacaoRow;

        private void FrmAdicionarLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDBDataSet.Locacao);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livro' table. You can move, or remove it, as needed.
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro   = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo    = (int)comboBox3.SelectedValue,
                Devolucao = dateTimePicker1.Value
            };
            this.Close();
        }
    }
}
