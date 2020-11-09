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
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }


        public int GetUncheckBillIDByTableID(int id)
        {
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
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idNewBill", new object[] { id });
        }

        public int GetMaxIDBill()
        {
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
            string query = "update dbo.Bill set status = 1, " + " discount = "+ discount +",totalPrice = " + totalPrice +" where idBill =" + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn ", new object[] { checkIn });
        }

        public DataTable GetBillListByDateAndPage(DateTime checkIn, int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn  , @page", new object[] { checkIn, pageNum });
        }

        public int GetNumBillListByDate(DateTime checkIn)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn ", new object[] { checkIn });
        }
    }
}
