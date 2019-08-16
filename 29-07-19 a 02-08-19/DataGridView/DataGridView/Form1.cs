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
    public partial class Form1 : Form
    {
        private object fmEdicaoCarros;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter1.CustomQuery(this.querysInnerJoinDataSet1.Carros);
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet.Carros' table. You can move, or remove it, as needed.


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 frmMarcas = new Form2();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form3 frmVendas = new Form3();
            frmVendas.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 frmUsuario = new Form4();
            frmUsuario.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
            var carSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridView.QuerysInnerJoinDataSet1.CarrosRow;

            //caso 
            switch (e.ColumnIndex)
            {
                //coluna que ele clicar caso o deletar
                case 0: {
                        this.carrosTableAdapter1.DeleteQuery(carSelect.Id);
                        
                    }break;
                case 1:
                    {
                        fmEdicaoCarros editCarro = new fmEdicaoCarros();
                        editCarro.CarrosRow = carSelect;
                        editCarro.ShowDialog();

                        this.carrosTableAdapter1.Update(editCarro.CarrosRow);
                        /*
                            editCarro.CarrosRow.Modelo,
                            editCarro.CarrosRow.Ano.ToString(),
                            editCarro.CarrosRow.Marca,
                            editCarro.CarrosRow.UsuInc,
                            DateTime.Now,
                            editCarro.CarrosRow.Id);*/
                    }
                    break;

            }
            this.carrosTableAdapter1.CustomQuery(this.querysInnerJoinDataSet1.Carros);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Lixeira lixo = new Lixeira();
            lixo.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fmAdicionar formAdd = new fmAdicionar();

            formAdd.ShowDialog();

            if(string.IsNullOrEmpty(formAdd.carrosRow?.Modelo))

            this.carrosTableAdapter1.Insert(
                formAdd.carrosRow.Modelo,
                formAdd.carrosRow.Ano,
                formAdd.carrosRow.Marca,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            //Atualiza
            this.carrosTableAdapter1.Fill(this.querysInnerJoinDataSet1.Carros);
        }
    }
}
