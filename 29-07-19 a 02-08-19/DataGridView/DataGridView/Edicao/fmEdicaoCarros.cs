using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView.Edicao
{
    public partial class fmEdicaoCarros : Form
    {
        public fmEdicaoCarros()
        {
            InitializeComponent();
        }

        public DataGridView.QuerysInnerJoinDataSet1.CarrosRow CarrosRow;


        private void FmEdicaoCarros_Load(object sender, EventArgs e)
        {
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);

            textBox1.Text           = CarrosRow.Modelo;
            dateTimePicker1.Value   = CarrosRow.Ano;
            comboBox1.SelectedValue = CarrosRow.Marca;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CarrosRow.Modelo = textBox1.Text;
            CarrosRow.Ano    = dateTimePicker1.Value;
            CarrosRow.Marca  = (int)comboBox1.SelectedValue;
        }

     
    }
}
