using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagementWinApp
{
    public partial class frmLogin : Form
    {
        IAccountRepository accountRepository = new AccountRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            try
            {
                if ("ADMIN".Equals(accountRepository.LoginAccount(txtEmail.Text, txtPassword.Text)))
                {
                    frmAdmin frmAdmin = new frmAdmin();
                    frmAdmin.ShowDialog();
                }
                else if ("STAFF".Equals(accountRepository.LoginAccount(txtEmail.Text, txtPassword.Text)))
                {
                    frmStaff frmStaff = new frmStaff();
                    frmStaff.ShowDialog();
                }
                else if ("EXPERT".Equals(accountRepository.LoginAccount(txtEmail.Text, txtPassword.Text)))
                {
                    frmExpert frmExpert = new frmExpert();
                    frmExpert.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your email is not existed");
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
            this.Close();
        }
    }
}
