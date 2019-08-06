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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarAutor frmAdd = new frmAdicionarAutor();
            frmAdd.ShowDialog();

            this.autoresTableAdapter.Insert(
                frmAdd.autorRow.Nome,
                frmAdd.autorRow.Descricao
                );
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
        }
    }
}
