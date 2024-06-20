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
    public partial class registration : Form
    {
        database bd = new database();

        public registration()
        {
            InitializeComponent();
        }

        private Boolean checkuser()
        {
            var Login = textBoxLog.Text;
            var Pass = textBoxPass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"SELECT id, username, password_user, statuse FROM users WHERE username = '{Login}' and password_user = '{Pass}'";

            SqlCommand command = new SqlCommand(querystring, bd.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var Login = textBoxLog.Text;
            var Pass = textBoxPass.Text;
            int statuse = 0;

            if (checkuser())
            {
                string querystirng = $"INSERT INTO users(username, password_user, statuse) VALUES('{Login}', '{Pass}', '{statuse}')";
                SqlCommand command = new SqlCommand(querystirng, bd.getConnection());

                bd.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт успешно создан!", "Успех!");
                    Login loginform1 = new Login();
                    this.Hide();
                    loginform1.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show($"Аккаунт {Login}, уже существует!");
            }
            bd.closeConnection();
        }
    }
}
