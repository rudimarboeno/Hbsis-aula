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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                     var userSelect = ((System.Data.DataRowView)
                     this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                     as DataGridView.QuerysInnerJoinDataSet1.UsuariosRow;

            fmEdicaoCarros editCarro = new fmEdicaoCarros();
            //editCarro.CarrosRow = userSelect;
            //editCarro.ShowDialog();

            this.usuariosTableAdapter.Update(editCarro.CarrosRow);

            this.usuariosTableAdapter.DeleteQuery(userSelect.Id);
            this.usuariosTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Usuarios);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmUsuarios formAdd = new frmUsuarios();
            formAdd.ShowDialog();

            this.usuariosTableAdapter.Insert(
                formAdd.carrosRow.Usuario,
                 true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza
            this.usuariosTableAdapter.Fill(this.querysInnerJoinDataSet1.Usuarios);
        }
    }
}
