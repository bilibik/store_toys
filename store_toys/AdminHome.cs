using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store_toys
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            Users userForm = new Users();
            this.Hide();
            userForm.ShowDialog();
            this.Show();
        }

        private void buttonToys_Click(object sender, EventArgs e)
        {
            Toys toysForm = new Toys();
            this.Hide();
            toysForm.ShowDialog();
            this.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            ResultAdmin resultForm = new ResultAdmin();
            this.Hide();
            resultForm.ShowDialog();
            this.Show();
        }
    }
}
