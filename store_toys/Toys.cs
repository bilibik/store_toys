using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;

namespace store_toys
{
    public partial class Toys : Form
    {
        database bd = new database();
        int selectedRow;

        public Toys()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Наименование");
            dataGridView1.Columns.Add("firm", "Фирма");
            dataGridView1.Columns.Add("count", "Количество");
            dataGridView1.Columns.Add("price", "Стоимость за штуку");
        }

        private void ReadSingleRow1(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetInt32(4));
        }

        private void RefreshDataGrid1()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select * from toys";
            SqlCommand command = new SqlCommand(queryString, bd.getConnection());

            bd.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow1(reader);
            }
            reader.Close();

            bd.closeConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxName.Text = row.Cells[1].Value.ToString();
                textBoxFirm.Text = row.Cells[2].Value.ToString();
                textBoxCount.Text = row.Cells[3].Value.ToString();
                textBoxPrice.Text = row.Cells[4].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Toys_Load_1(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid1();
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            ToysAdd toysaddForm = new ToysAdd();
            this.Hide();
            toysaddForm.ShowDialog();
            this.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            bd.openConnection();

            var id = textBoxId.Text;
            var name = textBoxName.Text;
            var firm = textBoxFirm.Text;
            var count = textBoxCount.Text;
            var price = textBoxPrice.Text;

            var changeQuery = $"update toys set name = '{name}', firm = '{firm}', count = '{count}', price = '{price}'  where id = '{id}'";

            var command = new SqlCommand(changeQuery, bd.getConnection());
            command.ExecuteNonQuery();
            bd.closeConnection();

            RefreshDataGrid1();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bd.openConnection();

            var id = Convert.ToInt32(textBoxId.Text);

            string query = $"delete from toys where id = {id} ";
            SqlCommand command = new SqlCommand(query, bd.getConnection());
            command.ExecuteNonQuery();

            bd.closeConnection();

            RefreshDataGrid1();
        }
    }
}
