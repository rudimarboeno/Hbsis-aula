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

namespace MVCProject.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            if (Session.user == null)
                throw new Exception("Erro de critico do sistema!");
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void LivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formLivro = new Form2();
            formLivro.ShowDialog();

        }

        private void UsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 formUsuario = new Form6();
            formUsuario.ShowDialog();
        }

        private void EditoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formEditora = new Form4();
            formEditora.ShowDialog();
        }

        private void GeneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 formGenero = new Form5();
            formGenero.ShowDialog();
        }

        private void LocaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 formLocacao = new Form7();
            formLocacao.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formAutores = new Form3();
            formAutores.ShowDialog();
        }
    }
}
