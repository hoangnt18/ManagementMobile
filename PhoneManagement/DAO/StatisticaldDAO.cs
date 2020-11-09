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
        private static StatisticaldDAO instance;

        internal static StatisticaldDAO Instance
        {
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

        //tạo một danh sách thống kê


        public List<StatisticaldDTO> LoadStatistical()
        {
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
