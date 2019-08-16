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
    public partial class frmAdicionarUsuario : Form
    {
        public frmAdicionarUsuario()
        {
            InitializeComponent();
        }

        public Usuario usuarioRow;

        private void FrmAdicionarUsuario_Load(object sender, EventArgs e)
        {
            //this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuarioRow = new Usuario
            {
                Nome = textBox1.Text,
                Login = textBox2.Text,
                Senha = textBox3.Text,
                Email = textBox4.Text

            };
            this.Close();
        }

     
    }
}
