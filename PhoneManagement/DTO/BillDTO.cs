using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class BillDTO
    {
        private int idBill;
        private DateTime? dateCheckIn;
        private int status;
        private int idNewBill;
        private int discount;

        public int IdBill { get => idBill; set => idBill = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int Status { get => status; set => status = value; }
        public int IdNewBill { get => idNewBill; set => idNewBill = value; }
        public int Discount { get => discount; set => discount = value; }

        public BillDTO(int idBill, DateTime? dateCheckIn, int idNewBill, int status, int discount)
        {
            this.IdBill = idBill;
            this.DateCheckIn = dateCheckIn;
            this.IdNewBill = idNewBill;
            this.Status = status;
            this.Discount = discount;
        }

        public BillDTO(DataRow row)
        {
            this.IdBill = (int)row["idBill"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];
            this.IdNewBill = (int)row["idNewBill"];
            this.Status = (int)row["status"];
            if (row["discount"].ToString() != "")
            {
                this.Discount = (int)row["discount"];
            }
        }


    }
}
