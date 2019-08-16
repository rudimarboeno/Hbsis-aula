using DataGridView.Adicionar;
using DataGridView.Edicao;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
               var vendasSelect = ((System.Data.DataRowView)
              this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.VendasRow;

            fmEdicaoCarros editCarro = new fmEdicaoCarros();
            //editCarro.CarrosRow = vendasSelect;
            //editCarro.ShowDialog();

            this.vendasTableAdapter.Update(editCarro.CarrosRow);

            this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmVendas frmvenda = new frmVendas();
            frmvenda.ShowDialog();

            //if(frmvenda.venda?.Carro > 0
            //    && frmvenda.venda?.Valor >0)

            this.vendasTableAdapter.Insert(
                frmvenda.carrosRow.Carro,
                frmvenda.carrosRow.Quantidade,
                frmvenda.carrosRow.Valor,
                frmvenda.carrosRow.Ativo, 
                1,
                1,
                 frmvenda.carrosRow.DatAlt,
               frmvenda.carrosRow.DatInc
                );
            //Atualiza
            this.vendasTableAdapter.Fill(this.querysInnerJoinDataSet1.Vendas);

        }
    }
}
