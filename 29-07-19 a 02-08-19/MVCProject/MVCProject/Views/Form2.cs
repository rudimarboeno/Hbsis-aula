using MVCProject.Adicionar;
using MVCProject.Views;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Livro' table. You can move, or remove it, as needed.
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);
       

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
           this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row as
           MVCProject.SistemaBibliotecaDBDataSet.LivroRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        frmLivroAutor frm = new frmLivroAutor();
                        frm.LivroRow = livroSelect;
                        frm.ShowDialog();
                    }
                    break;
            }

            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            frmAdiconarLivro frmAdiconar = new frmAdiconarLivro();
            frmAdiconar.ShowDialog();

            this.livroTableAdapter.Insert(
                frmAdiconar.livroRow.Registro,
                frmAdiconar.livroRow.Titulo,
                frmAdiconar.livroRow.Isbn,
                frmAdiconar.livroRow.Genero,
                frmAdiconar.livroRow.Editora,
                frmAdiconar.livroRow.Sinope,
                frmAdiconar.livroRow.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.livroTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Livro);
        }
    }
}
