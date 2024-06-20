﻿using System;
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
    public partial class ResultUser : Form
    {
        database bd = new database();
        int userid = data.userid;
        int selectedRow;

        public ResultUser()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("toys", "Наименование");
            dataGridView1.Columns.Add("count", "Количество");
            dataGridView1.Columns.Add("state", "Статус готовности");
        }

        private void ReadSingleRow1(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3));
        }

        private void RefreshDataGrid1()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select id, toys, count, state from result where iduser = '{userid}'";
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
                textBoxToys.Text = row.Cells[1].Value.ToString();
                textBoxCount.Text = row.Cells[2].Value.ToString();
                textBoxStatus.Text = row.Cells[3].Value.ToString();
            }
        }

        private void ResultUser_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid1();
        }

        private void buttonChangeStatus_Click(object sender, EventArgs e)
        {
            ResultAdd resultaddForm = new ResultAdd();
            this.Hide();
            resultaddForm.ShowDialog();
            this.Show();
        }

        private void buttonDeleteStatus_Click(object sender, EventArgs e)
        {
            bd.openConnection();

            var id = Convert.ToInt32(textBoxId.Text);

            string query = $"delete from result where id = {id} ";
            SqlCommand command = new SqlCommand(query, bd.getConnection());
            command.ExecuteNonQuery();

            bd.closeConnection();

            RefreshDataGrid1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshDataGrid1();
        }
    }
}
