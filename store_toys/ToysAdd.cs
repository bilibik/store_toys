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
    public partial class ToysAdd : Form
    {
        database bd = new database();
        public ToysAdd()
        {
            InitializeComponent();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            bd.openConnection();

            var name = textBoxName.Text;
            var firm = textBoxFirm.Text;
            var count = textBoxCount.Text;
            var price = textBoxPrice.Text;

            var query = $"insert into toys (name, firm, count, price) values ('{name}', '{firm}', '{count}', '{price}')";

            var command = new SqlCommand(query, bd.getConnection());
            command.ExecuteNonQuery();

            MessageBox.Show($"Запись {name} успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            bd.closeConnection();
        }
    }
}
