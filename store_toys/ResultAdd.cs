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
    public partial class ResultAdd : Form
    {
        database bd = new database();


        public ResultAdd()
        {
            InitializeComponent();
        }

        private void ResultAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toysDBDataSet.toys". При необходимости она может быть перемещена или удалена.
            this.toysTableAdapter.Fill(this.toysDBDataSet.toys);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "toysDBDataSet.result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.toysDBDataSet.result);

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            bd.openConnection();

            var toys = comboBoxToys.Text;
            var count = textBoxCount.Text;
            var statuse = "В обработке";
            var iduser = data.userid;

            var query = $"insert into result (toys, count, state, iduser) values ('{toys}', '{count}', '{statuse}', '{iduser}')";

            var command = new SqlCommand(query, bd.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show($"Заявка на {toys} передана на обработку!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bd.closeConnection();
        }
    }
}
