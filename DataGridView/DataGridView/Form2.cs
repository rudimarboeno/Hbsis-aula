using DataGridView.Adicionar;
using DataGridView.Edicao;
using DataGridView.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             var marcasSelect = ((System.Data.DataRowView)
             this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
              as DataGridView.QuerysInnerJoinDataSet1.MarcasRow;


            fmrEdicaoMarca editMarca = new fmrEdicaoMarca();
           // editMarca.CarrosRow = marcasSelect;
            editMarca.ShowDialog();

            this.marcasTableAdapter.Update(editMarca.CarrosRow);

            this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fmrAdicionarMarca formAdd = new fmrAdicionarMarca();
            formAdd.ShowDialog();

            this.marcasTableAdapter.Insert(
                formAdd.carrosRow.Nome,
                 true, 
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);
        }
    }
}
