using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace StudendDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle =  FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Студенты";
            label1.AutoSize = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "studentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.studentsDataSet.Студенты);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "ФИО ='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            студентыBindingSource.Filter = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = new DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {

                case 0: Col = dataGridView1.Columns[0]; break;
                case 1: Col = dataGridView1.Columns[1]; break;
                case 2: Col = dataGridView1.Columns[2]; break;
                case 3: Col = dataGridView1.Columns[3]; break;
                case 4: Col = dataGridView1.Columns[4]; break;
                case 5: Col = dataGridView1.Columns[5]; break;
                case 6: Col = dataGridView1.Columns[6]; break;
                case 7: Col = dataGridView1.Columns[7]; break;
                case 8: Col = dataGridView1.Columns[8]; break;
                case 10: Col = dataGridView1.Columns[10]; break;

                    if(radioButton1.Checked)
                    {
                        dataGridView1.Sort(Col, ListSortDirection.Ascending);

                    }
                    else
                    {
                        dataGridView1.Sort(Col, ListSortDirection.Descending);
                    }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< dataGridView1.ColumnCount - 1; i++)
            {
                for(int j = 0; j<dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.BackColor = Color.Black;
                }
            }

            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if(dataGridView1[i,j].Value.ToString() == textBox1.Text)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.BackColor = Color.Blue;
                    }
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
