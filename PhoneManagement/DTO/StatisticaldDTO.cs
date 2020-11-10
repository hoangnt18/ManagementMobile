using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class StatisticaldDTO
    {   
        private string name;
        private int countQuanlity;
        private float totalPrice;

        public string Name { get => name; set => name = value; }
        public int CountQuanlity { get => countQuanlity; set => countQuanlity = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public StatisticaldDTO(string name, int countQuanlity, float totalPrice)
        {
            this.Name = name;
            this.CountQuanlity = countQuanlity;
            this.TotalPrice = totalPrice;
        }

        public StatisticaldDTO(DataRow row)
        {
            // khai báo kiểu dữ liệu tương ứng với sql
            this.Name = row["name"].ToString();
            this.CountQuanlity = (int)row["COUNTQUALITY"];
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"]);
        }
    }
}
