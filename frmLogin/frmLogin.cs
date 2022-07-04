using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess;
using WinApp;

namespace frmLogin
{
    public partial class frmLogin : Form
    {
        IAccountRepository accountRepository;
        public frmLogin()
        {
            InitializeComponent();
            accountRepository = new AccountRepository();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            Account accountLogin = accountRepository.CheckLogin(userName, password);

            if (accountLogin != null)
            {
                if (accountLogin.Role == 1)
                {
                    frmHome adminHome = new frmHome()
                    {
                        accountLogin = accountLogin,
                    };
                    adminHome.ShowDialog();

                }
                else if (accountLogin.Role == 2)
                {
                    frmHomeStaff frmHomeStaff = new frmHomeStaff()
                    {
                        accountLogin = accountLogin,
                    };
                    frmHomeStaff.ShowDialog();
                }
                else if (accountLogin.Role == 3)
                {
                    frmHomeDoctor frmHomeDoctor = new frmHomeDoctor()
                    {
                        accountLogin = accountLogin,
                    };
                    frmHomeDoctor.ShowDialog();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
