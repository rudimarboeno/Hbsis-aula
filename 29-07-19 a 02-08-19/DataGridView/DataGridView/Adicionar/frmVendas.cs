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

namespace DataGridView.Adicionar
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        public Venda carrosRow;

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (nupdquantidade.Value < 1)
            {
                MessageBox.Show("Informe a quantodade");
                nupdquantidade.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txvalor.Text))
            {
                MessageBox.Show("Informe o valor");
                txvalor.Focus();
                return;
            }

            decimal valor = decimal.Parse(txvalor.Text);
            carrosRow = new Venda
            {
                Carro = (int) cbcarro.SelectedValue,
                Quantidade = (int)nupdquantidade.Value,
                Valor = valor
            };
            this.Close();
        }
    }
}
