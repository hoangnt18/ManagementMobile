using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    public class BillInListViewDAO
    {
        // tạo thể hiện phần cho phần tử BillInListViewDAO
        private static BillInListViewDAO instance;

        public static BillInListViewDAO Instance
        {// tạo thể hiện cho một BillInListViewDAO
            get
            {
                if (instance == null)
                {
                    instance = new BillInListViewDAO();
                }
                return instance;
            }
            private set => instance = value;
        }

        public BillInListViewDAO() { }


        public List<BillInListViewDTO> GetListBillByListView(int id)
        {
            //hiển thị sản phẩm có trong listview
            List<BillInListViewDTO> listBill = new List<BillInListViewDTO>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Phone AS f WHERE bi.idBill = b.idBill and b.status = 0 AND bi.idItemPhone = f.idItemPhone AND b.idNewBill  = "+id+" and b.status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInListViewDTO billListView = new BillInListViewDTO(item);
                listBill.Add(billListView);

            }


            return listBill;
        }
    }
}
