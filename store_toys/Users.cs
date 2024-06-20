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
using static System.Net.Mime.MediaTypeNames;

namespace store_toys
{
    public partial class Users : Form
    {
        database bd = new database();
        int selectedRow;

        public Users()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("username", "Пользователи");
            dataGridView1.Columns.Add("statuse", "Права администратора");
        }

        private void ReadSingleRow1(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetBoolean(2));
        }

        private void RefreshDataGrid1()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select id, username, statuse from users";
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

        private void Users_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxUser.Text = row.Cells[1].Value.ToString();
                textBoxStatus.Text = row.Cells[2].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bd.openConnection();

            var id = textBoxId.Text;
            var statuse = textBoxStatus.Text;

            var changeQuery = $"update users set statuse = '{statuse}' where id = '{id}'";

            var command = new SqlCommand(changeQuery, bd.getConnection());
            command.ExecuteNonQuery();
            bd.closeConnection();

            RefreshDataGrid1();
        }
    }
}
