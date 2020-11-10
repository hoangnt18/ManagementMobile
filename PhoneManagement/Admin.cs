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
    public partial class frmAdmin : Form
    {
        BindingSource listPhone = new BindingSource(); //tạo một bindingsource toàn cục để gán vào, khi binding không bị thay đổi
        BindingSource accountList = new BindingSource();
        public AccountDTO loginAccount;
        public frmAdmin()
        {

            InitializeComponent();
            dtgvShowPhone.DataSource = listPhone;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value);
            LoadListPhone();
            LoadCategoryinPhoneControl(cbxPhoneCategory);
            LoadAccount();
            ShowStatiscal();
            AddPhoneBinding();
            AddAcountBinding();
        }

        #region Methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);

        }

        void ShowStatiscal()
        {
            //Thống kê số lượng mặt hàng bán được, sắp xếp từ trên xuống
            dtgvStatistical.DataSource = StatisticaldDAO.Instance.LoadStatistical();
        } 

        void LoadListBillByDate(DateTime dateCheckIn)
        {
            //Load danh sách hóa đơn theo ngày check in
            dtgvTarget.DataSource = BillDAO.Instance.GetBillListByDate(dateCheckIn);
        }

        void LoadListPhone()
        {
            // load danh sách điện thoại
            listPhone.DataSource = TableDao.Instance.GetListPhone1();
        }

        void LoadCategoryinPhoneControl(ComboBox cb)
        {
            // load danh sách mục điện thoại và phụ kiện nằm vào combobox
            cb.DataSource = PhoneCategoryDAO.Instance.LoadTableListPhoneCate();
            cb.DisplayMember = "Name";
        }

        void AddPhoneBinding()
        {
            // lấy data tương ứng khi binding
            txtPhoneName.DataBindings.Add(new Binding("Text", dtgvShowPhone.DataSource, "Name", true, DataSourceUpdateMode.Never)); // true chấp nhận ép kiểu, DataSourceUpdateMode.Never: không bao giờ thay đổi giá trị khi load
            txtPhoneID.DataBindings.Add(new Binding("Text", dtgvShowPhone.DataSource, "IdPhone", true, DataSourceUpdateMode.Never));
            txtPhonePrice.DataBindings.Add(new Binding("Text", dtgvShowPhone.DataSource, "Price", true, DataSourceUpdateMode.Never));
            txtIdItemPhone.DataBindings.Add(new Binding("Text", dtgvShowPhone.DataSource, "idItemPhone", true, DataSourceUpdateMode.Never));
            // kĩ thuật binding, thằng này theo đổi, thằng sau thay dổi theo
            //Từ txtPhoneName lấy giá trị text, thuộc tính của text sẽ thay đổi theo giá trị của Name nằm trong DataSource

        }
        List<Table> SearchFoodByName(string name)
        {
            // tìm kiếm danh sách điện thoại khi search
            List<Table> listPhoneSearch = TableDao.Instance.SearchPhoneByName(name);
            return listPhoneSearch;
        }
        void AddAcountBinding()
        {
            //  binding account để lấy data tương ứng
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmrAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDao.Instance.GetListAccount();
        }

        void AddAccount(string userName, string displayName, int type)
        { // thêm account
            if (AccountDao.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Account added successfully");
            }
            else
            {
                MessageBox.Show("Account add failed");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            //update account
            if (AccountDao.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Successful account update");
            }
            else
            {
                MessageBox.Show("Account update failed");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            // Xóa account
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Please don't delete yourself");
                return;
            }
            if (AccountDao.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Account deleted successfully");
            }
            else
            {
                MessageBox.Show("Account deletion failed");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            //Đặt lại mật khẩu
            if (AccountDao.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Password reset was successful");
            }
            else
            {
                MessageBox.Show("Password reset failed");
            }
        }

        #endregion

        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            // Load danh sách hóa đơn theo ngày check in khi click
            LoadListBillByDate(dtpkFromDate.Value);
        }



        private void btnWatch_Click(object sender, EventArgs e)
        {
           
            LoadListPhone();
        }

        private void txtPhoneID_TextChanged(object sender, EventArgs e)
        { 
            //event khi binding show mục hiển thị điện thị tương ứng
            try
            {
                if (dtgvShowPhone.SelectedCells.Count > 0)
                {
                    int id = (int)dtgvShowPhone.SelectedCells[0].OwningRow.Cells["IdPhone"].Value;

                    PhoneCategoryDTO category = PhoneCategoryDAO.Instance.GetCategoryByIdPhone(id);

                    cbxPhoneCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (PhoneCategoryDTO item in cbxPhoneCategory.Items)
                    {
                        if (item.IdPhone == category.IdPhone)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbxPhoneCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // thêm một item điện thoại khi click
            string name = txtPhoneName.Text;
            int idPhone = (cbxPhoneCategory.SelectedItem as PhoneCategoryDTO).IdPhone;
            float price = float.Parse(txtPhonePrice.Text);

            if (TableDao.Instance.InsertPhone(idPhone, name, price))
            {
                MessageBox.Show("Add successfully");
                LoadListPhone();
                if (insertPhone != null)
                    insertPhone(this, new EventArgs());
            }

            else
            {
                MessageBox.Show("Add Failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update một item điện thoại khi click
            string name = txtPhoneName.Text;
            int idPhone = (cbxPhoneCategory.SelectedItem as PhoneCategoryDTO).IdPhone;
            ///int idPhone = Int32.Parse(txtPhoneID.Text);
            float price = float.Parse(txtPhonePrice.Text);
            int idItemPhone = Int32.Parse(txtIdItemPhone.Text);


            if (TableDao.Instance.UpdatePhone(idPhone, idItemPhone, name, price))
            {
                MessageBox.Show("Update successfully");
                LoadListPhone();
                if (updatePhone != null)
                    updatePhone(this, new EventArgs());
            }

            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Xóa một item điện thoại
            int idItemPhone = Int32.Parse(txtIdItemPhone.Text);

            if (TableDao.Instance.DeletePhone(idItemPhone))
            {
                MessageBox.Show("Update successfully");
                LoadListPhone();
                if (deletePhone != null)
                    deletePhone(this, new EventArgs());
            }

            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private event EventHandler insertPhone;
        public event EventHandler InsertPhone
        {
            // event bắt sự kiện khi thêm một phần tử, mục đích là để cập nhật lại list
            add { insertPhone += value; }
            remove { insertPhone -= value; }
        }

        private event EventHandler deletePhone;
        public event EventHandler DeletePhone
        {
            // event bắt sự kiện khi xóa một phần tử, mục đích là để cập nhật lại list
            add { deletePhone += value; }
            remove { deletePhone -= value; }
        }

        private event EventHandler updatePhone;
        public event EventHandler UpdatePhone
        {
            // event bắt sự kiện khi cập nhật một phần tử, mục đích là để cập nhật lại list
            add { updatePhone += value; }
            remove { updatePhone -= value; }
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            listPhone.DataSource = SearchFoodByName(txtPhoneSearch.Text);
        }

        private void bntShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnAddAdcount_Click(object sender, EventArgs e)
        {
            // thêm một account khi click
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmrAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            // xóa một account khi click
            string userName = txtUserName.Text;

            DeleteAccount(userName);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            // cập nhật lại account khi click
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmrAccountType.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            // đặt lại mật khẩu khi click
            string userName = txtUserName.Text;

            ResetPass(userName);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            // cho page đầu tiên là 1
            txtPageBill.Text = "1";
        }

        private void btnPevious_Click(object sender, EventArgs e)
        {
            // lùi lại 1 trang khi click

            int page = Convert.ToInt32(txtPageBill.Text);

            if (page > 1)
                page--;

            txtPageBill.Text = page.ToString();
        }

        private void txtPageBill_TextChanged(object sender, EventArgs e)
        {
            // dtgvTarget thay đổi khi thay nhấn button < << >> >
            dtgvTarget.DataSource = BillDAO.Instance.GetBillListByDateAndPage(dtpkFromDate.Value, Convert.ToInt32(txtPageBill.Text));
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // chuyển trang kế tiếp khi click
            int page = Convert.ToInt32(txtPageBill.Text);
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value);

            if (page < sumRecord)
                page++;

            txtPageBill.Text = page.ToString();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int sumRecord = BillDAO.Instance.GetNumBillListByDate(dtpkFromDate.Value);

            int lastPage = sumRecord / 10;

            if (sumRecord % 10 != 0)
                lastPage++;

            txtPageBill.Text = lastPage.ToString();
        }
        private void tpPhone_Click(object sender, EventArgs e)
        {

        }

        private void dtgvTarget_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion




    }
}
