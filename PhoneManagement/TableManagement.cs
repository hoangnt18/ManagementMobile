using PhoneManagement.DAO;
using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagement
{
    public partial class frmTableManagement : Form
    {

        private AccountDTO loginAccount;
        
        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public frmTableManagement(AccountDTO account)
        {
            InitializeComponent();
            this.LoginAccount = account;
            LoadNewBill();
            LoadPhoneCategory();
        }
        #region Method
        void LoadPhoneCategory()
        {
            // hiển thị danh sách mục điện thoại
            List<PhoneCategoryDTO> tableList = PhoneCategoryDAO.Instance.LoadTableListPhoneCate();
            foreach (PhoneCategoryDTO itemPhoneCate in tableList)
            {
                Button btn = new Button() { Width = PhoneCategoryDAO.TableWidth, Height = PhoneCategoryDAO.TabHeight };
                btn.Text = itemPhoneCate.Name + Environment.NewLine;
                btn.Click += Btn_Click;
                btn.Tag = itemPhoneCate;
                switch (itemPhoneCate.Name)
                {
                    case "APPLE":
                        {
                            btn.BackColor = Color.White;
                            break;
                        }

                    case "SAMSUNG":
                        {
                            btn.BackColor = Color.LightSkyBlue;
                            break;
                        }

                    case "HUAWEI":
                        {
                            btn.BackColor = Color.LightBlue;
                            break;
                        }

                    case "OPPO":
                        {
                            btn.BackColor = Color.LightYellow;
                            break;
                        }
                    case "VIVO":
                        {
                            btn.BackColor = Color.LightSteelBlue;
                            break;
                        }
                    case "VSMART":
                        {
                            btn.BackColor = Color.Red;
                            break;
                        }
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
               // btn.Enabled = false;
                flpPhoneCate.Controls.Add(btn);               
            }
        }

        void ShowListPhone(int id)
        { // hiển thị danh sách điện thoại  1 phần tử được chọn
            flpPhoneCate.Controls.Clear();

            List<Table> tableList = TableDao.Instance.GetListPhone(id);
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDao.TableWidth, Height = TableDao.TabHeight };
                btn.Text = item.Name + Environment.NewLine + item.Price;
                btn.BackColor = Color.Aqua;
                btn.Click += Btn_Click1;
                btn.Tag = item;
                btn.BackColor = Color.LightPink;

                flpPhoneCate.Controls.Add(btn);
            }
        }

        public void ShowBill(int id)
        { // Show hóa listview sau khi thêm sản phẩm
            lsvBill.Items.Clear();
            List<BillInListViewDTO> listBillInfo = BillInListViewDAO.Instance.GetListBillByListView(id);
            float toTalPrice = 0;
            foreach (BillInListViewDTO item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                toTalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtPayMone.Text = toTalPrice.ToString("c", culture);
        }

        void ChangeAccount(int type) //Hiển thị tên account trên information account
        {
            adminToolStripMenuItem.Enabled = type == 1;
            mtsInformationAccount.Text += " (" + LoginAccount.DisPlayName + ")";
            //MessageBox.Show(LoginAccount.DisPlayName);
        }

        public void LoadNewBill() 
        {
            //Hiển thị NewBill
            flpBill.Controls.Clear();
            List<NewBillDTO> tableList = NewBillDAO.Instance.LoadNewBill();
            foreach (NewBillDTO item in tableList)
            {
                Button btn = new Button() { Width = NewBillDAO.TableWidth, Height = NewBillDAO.TabHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click2;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "New Bill":
                        {
                            btn.BackColor = Color.Yellow;
                            break;
                        }
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flpBill.Controls.Add(btn);
            }
        }

        #endregion



        #region Event
        private void Btn_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as PhoneCategoryDTO).IdPhone;
            ShowListPhone(id);
        }

        private void Btn_Click1(object sender, EventArgs e)
        { //thêm các phàn tử vào textbox để add item vào listView
            int id = ((sender as Button).Tag as Table).IdPhone;
            int idItemPhone = ((sender as Button).Tag as Table).IdItemPhone;
            string namePhone = ((sender as Button).Tag as Table).Name;
            float price = ((sender as Button).Tag as Table).Price;
            txtNamePhone.Text = namePhone;
            txtID.Text = id.ToString();
            txtPrice.Text = price.ToString();
            txtIdItemPhone.Text = idItemPhone.ToString();
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            this.Hide();
            f.loginAccount = LoginAccount;
            f.InsertPhone += F_InsertPhone;
            f.DeletePhone += F_DeletePhone;
            f.UpdatePhone += F_UpdatePhone;
            f.ShowDialog();
            this.Show();
        }

        private void F_UpdatePhone(object sender, EventArgs e)
        {
            LoadPhoneCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).IdItemPhone);
        }

        private void F_DeletePhone(object sender, EventArgs e)
        {
            LoadPhoneCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).IdItemPhone);
        }

        private void F_InsertPhone(object sender, EventArgs e)
        {
            LoadPhoneCategory();
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).IdItemPhone);
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformationPrivate f = new frmInformationPrivate(LoginAccount);
            f.UpdateAccount += F_UpdateAccount;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRefersh_Click(object sender, EventArgs e)
        {
            flpPhoneCate.Controls.Clear();
            LoadPhoneCategory();
        }

        private void btnDelete_Click(object sender, EventArgs e) 
        {
            //Xóa 1 phần tử trong listview trước khi nhấn add
            foreach (ListViewItem eachItem in lsvBill.SelectedItems)
            {
                lsvBill.Items.Remove(eachItem);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            NewBillDTO newBill = lsvBill.Tag as NewBillDTO;
            int discount = (int)nmrDiscount.Value;

            double totalPrice = double.Parse(txtPayMone.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(newBill.IdNewBill);
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Are you sure you pay the bill number {0}\n Total pay: {1}\n  Discount: {2}\n Final total pay:{3} ", newBill.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(newBill.IdNewBill);
                    LoadNewBill();
                    MessageBox.Show("data has been saved to sql");
                }
            }
        }

        private void Btn_Click2(object sender, EventArgs e)
        {
            int idNewBill = ((sender as Button).Tag as NewBillDTO).IdNewBill;
            lsvBill.Tag = (sender as Button).Tag;
            txtIdNewBill.Text = idNewBill.ToString();
            ShowBill(idNewBill);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtIdNewBill.Text == "")
            {
                MessageBox.Show("Please select Newbill before adding products", "Warning");
                return;
            } //Kiểm tra idNewBill chưa tồn tại thì sẽ bấm NewBill trước khi thêm sản phẩm

            // Add sản phẩm vào list view
            NewBillDTO newBill = lsvBill.Tag as NewBillDTO;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(newBill.IdNewBill);
            int idItemPhone = Int16.Parse(txtIdItemPhone.Text);
            int count = (int)nmrAmount.Value;

            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(newBill.IdNewBill);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), idItemPhone, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idItemPhone, count);
            }

            ShowBill(newBill.IdNewBill);
            LoadNewBill();
        }

        private void F_UpdateAccount(object sender, AccountEvent e)
        {
            mtsInformationAccount.Text = "Information account (" + e.Acc.DisPlayName + ")";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPhoneCategory_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTableManagement_Load(object sender, EventArgs e)
        {

        }


        private void flpBill_Paint(object sender, PaintEventArgs e)
        {

        }
        private void mtsInformationAccount_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmLogin f = new frmLogin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }

}
