using PhoneManagement.DAO;
using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Methods 

        bool Login1(string userName, string passWord) // kiểm tra  login
        {
            return AccountDao.Instance.Login(userName, passWord);
        }

        #endregion

        #region Event

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to program?", "Warning", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            if (Login1(userName, passWord))
            {
                AccountDTO loginAccount = AccountDao.Instance.GetAccountByUserName(userName);
                frmTableManagement t = new frmTableManagement(loginAccount);
                this.Hide();
                t.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Wrong account or password!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void lblUserName_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
