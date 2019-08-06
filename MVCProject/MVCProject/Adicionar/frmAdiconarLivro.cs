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
    public partial class frmAdiconarLivro : Form
    {
        public frmAdiconarLivro()
        {
            InitializeComponent();
        }
        public Livro livroRow;

        private void FrmAdiconarLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Locacao);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRow = new Livro
            {
                Titulo = textBox1.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox2.SelectedValue,
                Registro = (int)comboBox3.SelectedValue,
                Isbn = textBox5.Text,
                Sinope = textBox6.Text,
                Observacoes = textBox7.Text
            };
            this.Close();
        }
    }
}
