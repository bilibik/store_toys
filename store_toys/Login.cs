using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace store_toys
{
    public partial class Login : Form
    {
        database bd = new database();

        public Login()
        {
            InitializeComponent();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            var Login = textBoxLog.Text;
            var Password = textBoxPass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string query = $"SELECT id, username, password_user, statuse FROM users WHERE username = '{Login}' AND password_user = '{Password}'";
            SqlCommand command = new SqlCommand(query, bd.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count >= 1)
            {
                int id = Convert.ToInt32(table.Rows[0]["id"]);
                data.userid = id;

                MessageBox.Show($"Успешный вход, здравствуйте {Login}", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Convert.ToInt32(table.Rows[0]["statuse"]) == 1)
                {
                    AdminHome adminhome1 = new AdminHome();
                    this.Hide();
                    adminhome1.ShowDialog();
                    this.Show();
                }
                else
                {
                    UserHome userhome1 = new UserHome();
                    this.Hide();
                    userhome1.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Ошибка! Такого аккаунта не найдено!", "Введенные данные не найдены!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RegistrButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registration regis = new registration();
            this.Hide();
            regis.ShowDialog();
            this.Show();
        }
    }
}
