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
    public partial class fmrEdicaoMarca : Form
    {
        public fmrEdicaoMarca()
        {
            InitializeComponent();
        }
        public DataGridView.QuerysInnerJoinDataSet1.CarrosRow CarrosRow;

        private void FmrEdicaoMarca_Load(object sender, EventArgs e)
        {
            //this.marcasTableAdapter.FillBy(this.QuerysInnerJoinDataSet1.Marca);

            //dateTimePicker1.Value = CarrosRow.Ano;
            //comboBox1.SelectedValue = CarrosRow.Marca;
        }
    } 
}
