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

namespace store_toys
{
    public partial class ToysUser : Form
    {
        database bd = new database();


        public ToysUser()
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

        private void ToysUser_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid1();
        }
    }
}

