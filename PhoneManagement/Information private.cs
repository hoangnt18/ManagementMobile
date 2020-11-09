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
    public partial class frmInformationPrivate : Form
    {

        private AccountDTO loginAccount;

        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        void ChangeAccount(AccountDTO account)
        {
            txtIPUserName.Text = LoginAccount.UserName;
            txtIPDisplayName.Text = LoginAccount.DisPlayName;

        }

        public frmInformationPrivate(AccountDTO account)
        {
            InitializeComponent();
            LoginAccount = account;
        }

        void UpdateAccountInfor()
        {
            string userName = txtIPUserName.Text;
            string disPlayName = txtIPDisplayName.Text;
            string password = txtIPPassword.Text;
            string newPassword = txtIPNewPassword.Text;
            string reEnterPass = txtIPReEnterPass.Text;
            

            if (!newPassword.Equals(reEnterPass))
            {
                MessageBox.Show("Please re-enter the correct password with the new password!");
            }
            else
            {
                if (AccountDao.Instance.UpdateAccount(userName, disPlayName, password, newPassword))
                {
                    MessageBox.Show("Update successful");
                    if (updateAccount != null)
                    {
                        updateAccount(this, new AccountEvent(AccountDao.Instance.GetAccountByUserName(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the correct password");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void txbReEnterPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInformationPrivate_Load(object sender, EventArgs e)
        {

        }
    }

    public class AccountEvent : EventArgs // kế thừa từ EventArgs để
    {
        private AccountDTO acc;

        public AccountDTO Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(AccountDTO account)
        {
            this.Acc = account;
        }
    }
}
