using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class BillInListViewDTO
    {
        private string name;
        private int count;
        private float price;
        private float totalPrice;

        public string Name { get => name; set => name = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public BillInListViewDTO(string name, int count, float price, float totalPice)
        {
            this.Name = name;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPice;
        }

        public BillInListViewDTO(DataRow row)
        {
            this.Name= row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["ToTalPrice"].ToString());
        }
    }
}
