using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudendDB
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void студентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Специальности". При необходимости она может быть перемещена или удалена.
            this.специальностиTableAdapter.Fill(this.studentsDataSet.Специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            студентыBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            студентыBindingSource.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.студентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentsDataSet);
        }

        private void полComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }
    }
}
