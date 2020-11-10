using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    class StatisticaldDAO
    {
        // tạo thể hiện phần cho phần tử phone
        private static StatisticaldDAO instance;

        internal static StatisticaldDAO Instance
        {// tạo thể hiện cho một StatisticaldDAO
            get
            {
                if(instance == null)
                {
                    instance = new StatisticaldDAO();
                }
                return instance;
            } 
            private set => instance = value;
        }

        public StatisticaldDAO() { }

        


        public List<StatisticaldDTO> LoadStatistical()
        {
            //tạo một danh sách thống kê
            List<StatisticaldDTO> listStatis= new List<StatisticaldDTO>();
            string query = " exec USP_GetCountQuanlity";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                StatisticaldDTO statis = new StatisticaldDTO(item);
                listStatis.Add(statis);
            }
            return listStatis;
        }
    }
}
