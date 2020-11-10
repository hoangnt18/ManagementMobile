using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
     class BillDAO
    {
        // tạo thể hiện phần tử cho BillDao
        private static BillDAO instance;

        public static BillDAO Instance
        {// tạo thể hiện phần cho BillDao
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }


        public int GetUncheckBillIDByNewBillID(int id)
        {
            // kiểm tra bill tồn tại

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idNewBill = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                BillDTO bill = new BillDTO(data.Rows[0]);
                return bill.IdBill;
            }

            return -1;
        }

        public void InsertBill(int id)
        {
            //thêm bill
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idNewBill", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            // láy id lớn nhất 
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(idBill) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int id, int discount, float totalPrice)
        {
            // hàm thanh toán hóa đơn
            string query = "update dbo.Bill set status = 1, " + " discount = "+ discount +",totalPrice = " + totalPrice +" where idBill =" + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn)
        {
            // lấy danh sách bill theo ngày 
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn ", new object[] { checkIn });
        }

        public DataTable GetBillListByDateAndPage(DateTime checkIn, int pageNum)
        {
            // lấy danh sách hóa đươn theo trang
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn  , @page", new object[] { checkIn, pageNum });
        }

        public int GetNumBillListByDate(DateTime checkIn)
        {
            // trả về số hóa đơn theo ngày
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn ", new object[] { checkIn });
        }
    }
}
