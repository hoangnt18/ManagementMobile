using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    class BillInfo
    {
        private DataRow item;
        public BillInfo(DataRow item)
        {
            this.item = item;
        }
    }
}
