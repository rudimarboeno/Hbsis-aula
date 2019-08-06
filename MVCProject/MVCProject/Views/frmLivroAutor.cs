﻿using System;
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
    public partial class frmLivroAutor : Form
    {
        public frmLivroAutor()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDBDataSet.LivroRow LivroRow;
        private void FrmLivroAutor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.LivroAutor, LivroRow.Id);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Autores);

            label2.Text = LivroRow.Titulo;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.livroAutorTableAdapter.Insert(LivroRow.Id,
              (int)comboBox1.SelectedValue);

          

            this.livroAutorTableAdapter.FillBy(this.sistemaBibliotecaDBDataSet.LivroAutor, LivroRow.Id);
        }
    }
}
