using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class PhoneCategoryDTO
    {
        private int idStore;
        private int idPhone;
        private string name;


        public string Name { get => name; set => name = value; }
        public int IdStore { get => idStore; set => idStore = value; }
        public int IdPhone { get => idPhone; set => idPhone = value; }

        public PhoneCategoryDTO(int idStore, int idPhone, string name)
        {
            this.IdStore = idStore;
            this.IdPhone = idPhone;
            this.Name = name;
            
        }

        public PhoneCategoryDTO(DataRow row)
        {
            this.IdStore = (int)row["idStore"];
            this.IdPhone = (int)row["idPhone"];
            this.Name = row["name"].ToString();
        }
    }
}
