using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    public class NewBillDAO
    {
        private static NewBillDAO instance;



       

        public static int TableWidth = 80;
        public static int TabHeight = 80;

        public static NewBillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NewBillDAO();
                return instance;
            }
            private set => instance = value;
        }

        public void NewBillDao()
        {

        }

        public List<NewBillDTO> LoadNewBill()
        {
            List<NewBillDTO> tableList = new List<NewBillDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("  select * from dbo.newBill");

            foreach (DataRow item in data.Rows)
            {
                NewBillDTO table = new NewBillDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
