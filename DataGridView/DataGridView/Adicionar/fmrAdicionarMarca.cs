﻿using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Adicionar
{
    public partial class fmrAdicionarMarca : Form
    {
        public fmrAdicionarMarca()
        {
            InitializeComponent();
        }
        public Marca carrosRow;

        private void FmrAdicionarMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            carrosRow = new Marca
            {
                Nome = textBox1.Text
            };

            this.Close();

        }
    }
}
