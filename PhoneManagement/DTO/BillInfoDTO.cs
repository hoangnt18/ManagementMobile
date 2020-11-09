using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class BillInfoDTO
    {
        private int idBillInfo;
        private int idBill;
        private int idItemPhone;
        private int count;

        
        
        public int Count { get => count; set => count = value; }
        public int IdItemPhone { get => idItemPhone; set => idItemPhone = value; }
        public int IdBillInfo { get => idBillInfo; set => idBillInfo = value; }
        public int IdBill { get => idBill; set => idBill = value; }

        public BillInfoDTO(int idBillInfo, int idItemPhone, int count, int idBill)
        {
            this.IdBillInfo = idBillInfo;
            this.IdBill = idBill;
            this.IdItemPhone = idItemPhone;
            this.Count = count;
        }

        public BillInfoDTO(DataRow row)
        {
            this.IdBillInfo = (int)row["idBillInfo"];
            this.idBill = (int)row["idBill"];
            this.IdItemPhone =(int) row["idItemPhone"];
            this.Count = (int)row["count"];
        }

    }
}
