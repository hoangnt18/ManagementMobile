using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class NewBillDTO
    {
        
        private int idNewBill;
        private string name;
        private string status;

        public int IdNewBill { get => idNewBill; set => idNewBill = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }

        public NewBillDTO(int idNewBill, string name, string status)
        {
            this.IdNewBill = idNewBill;
            this.Name = name;
            this.Status = status;
        }

        public NewBillDTO(DataRow row)
        {
            // khai báo kiểu dữ liệu tương ứng với sql
            this.IdNewBill = (int)row["idNewBill"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }


    }
}
