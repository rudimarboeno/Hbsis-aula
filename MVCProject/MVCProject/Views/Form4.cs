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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarEditora frmAdd = new frmAdicionarEditora();
            frmAdd.ShowDialog();

            this.editorasTableAdapter.Insert(
                frmAdd.editoraRow.Nome,
                frmAdd.editoraRow.Descricao
                );
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Editoras);
        }
    }
}
