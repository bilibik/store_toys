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
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void buttonToys_Click(object sender, EventArgs e)
        {
            ToysUser toysForm = new ToysUser();
            this.Hide();
            toysForm.ShowDialog();
            this.Show();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            ResultUser resultForm = new ResultUser();
            this.Hide();
            resultForm.ShowDialog();
            this.Show();
        }
    }
}
