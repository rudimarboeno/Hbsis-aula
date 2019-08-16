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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAdicionarUsuario formAdd = new frmAdicionarUsuario();
            formAdd.ShowDialog();

            this.usuariosTableAdapter.Insert(
                formAdd.usuarioRow.Nome,
                formAdd.usuarioRow.Login,
                formAdd.usuarioRow.Senha,
                formAdd.usuarioRow.Email,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);
        }
    }
}
