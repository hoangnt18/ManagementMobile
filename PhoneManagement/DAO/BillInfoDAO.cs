using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillInfoDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BillInfoDAO() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillInfo as bi where bi.id = "+id+" ");
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }
            return listBillInfo;
        }

        public void InsertBillInfo(int idBill, int idItemPhone, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo3 @idBill , @idItemPhone , @count", new object[] { idBill, idItemPhone, count });
        }

        public void DeleteBillInfor(int idItemPhone)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo WHERE idItemPhone = " + idItemPhone);
        }

    }
}
