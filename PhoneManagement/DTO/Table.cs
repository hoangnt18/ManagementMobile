using PhoneManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{

    public class Table
    {
        private int idPhone;
        private string name;
        private int idItemPhone;
        private float price;

       
        public string Name { get => name; set => name = value; }
        public int IdItemPhone { get => idItemPhone; set => idItemPhone = value; }
        public float Price { get => price; set => price = value; }
        public int IdPhone { get => idPhone; set => idPhone = value; }

        public Table(int idPhone, string name  ,int idItemPhone, float price)
        {
            this.IdPhone = idPhone;
            this.name = name;
            this.IdItemPhone = idItemPhone;
            this.price = price;
        }

        public Table(DataRow row)
        {
            this.IdPhone = (int)row["idPhone"];
            this.Name = row["name"].ToString();
            this.IdItemPhone = (int)row["idItemPhone"];
            this.Price = (float)Convert.ToDouble(row["price"]);

        }

       

    }
}
