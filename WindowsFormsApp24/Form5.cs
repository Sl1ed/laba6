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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void оценкиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.оценкиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Оценки". При необходимости она может быть перемещена или удалена.
            this.оценкиTableAdapter.Fill(this.database1DataSet.Оценки);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            средний_баллTextBox.Text = Convert.ToString((Convert.ToSingle(оценка_1TextBox.Text) + Convert.ToSingle(оценка_2TextBox.Text)) / 2);
            Validate();
            оценкиBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(database1DataSet);
        }
    }
}
