using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    public class TableDao
    {
        private static TableDao instance;

        public static int TableWidth = 80;
        public static int TabHeight = 80;

        public  static TableDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDao();
                return instance;
            }
            private set => instance = value;
        }

        public void TableDAO()
        {

        }

        public List<Table> GetListPhone(int idPhone)
        {
            //hàm show danh sách sản phẩm theo id
            List<Table> tableList = new List<Table>();
            string query = "select p.name, p.idPhone, p.price, p.idItemPhone from dbo.Phone p, dbo.PhoneCategory pc where p.idPhone = pc.idPhone and p.idPhone = N'"+ idPhone + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public List<Table> GetListPhone1()
        {
            // hàm show danh sách sản phẩm
            List<Table> tableList = new List<Table>();
            string query = "select p.name, p.idPhone, p.price, p.idItemPhone from dbo.Phone p, dbo.PhoneCategory pc where p.idPhone = pc.idPhone";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public bool InsertPhone( int idPhone ,string name, float price)
        {
            // hàm thêm 1 sản phẩm
            string query = string.Format("insert dbo.Phone(idPhone,name,price) values({0},N'{1}',{2})", idPhone,name, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool UpdatePhone(int idPhone,int idItemPhone ,string name, float price)
        {
            // hàm update 1 sản pharm
            string query = string.Format("update dbo.Phone set  idPhone = {0},name = N'{1}' , price = {2} where idItemPhone = {3}", idPhone,name, price, idItemPhone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

        public bool DeletePhone(int idItemPhone)
        {   // hàm xóa 1 sản phẩm
            //Trước khi delete Item thì phải xóa item BillInfor
            BillInfoDAO.Instance.DeleteBillInfor(idItemPhone);
            string query = string.Format("delete dbo.Phone where idItemPhone = {0} ", idItemPhone);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;

        }

          public List<Table> SearchPhoneByName(string name)
        {
            // hàm liệt ke danh sách sản phẩm điện thoại tìm được
            List<Table> list = new List<Table>();

            string query = string.Format("SELECT * FROM dbo.Phone WHERE dbo.fuConvertToUnsign1(name) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            //% trước và sau , tìm tất cả kí tự tồn tại trước và sau có trong chuỗi đó
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Table phone = new Table(item);
                list.Add(phone);
            }

            return list;
        }


    }
}
