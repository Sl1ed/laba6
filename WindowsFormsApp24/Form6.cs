using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.database1DataSet.Студенты);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = dataGridViewTextBoxColumn2;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Col = dataGridViewTextBoxColumn2;
                    break;
                case 1:
                    ;
                    break;
                case 2:
                    Col = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    Col = dataGridViewTextBoxColumn5;
                    break;
                case 4:
                    Col = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    Col = dataGridViewTextBoxColumn7;
                    break;
                case 6:
                    Col = dataGridViewTextBoxColumn8;
                    break;
                case 7:
                    Col = dataGridViewTextBoxColumn9;
                    break;
                case 8:
                    Col = dataGridViewTextBoxColumn10;
                    break;
                case 9:
                    Col = dataGridViewTextBoxColumn11;
                    break;
                case 10:
                    Col = dataGridViewTextBoxColumn12;
                    break;
            }
            if (radioButton1.Checked)
                студентыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            else
                студентыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "ФИО='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < студентыDataGridView.ColumnCount; i++)
                for (int j = 0; j < студентыDataGridView.RowCount; j++)
                {
                    студентыDataGridView[i, j].Style.BackColor = Color.White;
                    студентыDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            for (int i = 0; i < студентыDataGridView.ColumnCount; i++)
                for (int j = 0; j < студентыDataGridView.RowCount - 1; j++)
                    if (студентыDataGridView[i, j].Value.ToString().Contains(textBox1.Text))
                    {
                        студентыDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        студентыDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
