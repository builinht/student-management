using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            UserObject user = userRepository.GetUsers().SingleOrDefault(pro => pro.UserEmail == txtEmail.Text && pro.UserPassword == txtPassword.Text);
            if (user != null)
            {
                frmMain frm = new frmMain(user);
                frm.Show();

            }
            else
            {
                MessageBox.Show("Invalid email or password ! ");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d;
            d = MessageBox.Show("Do you want to exit ?", "Login",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
