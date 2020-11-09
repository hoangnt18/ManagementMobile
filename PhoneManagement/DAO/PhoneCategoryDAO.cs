using PhoneManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DAO
{
    public class PhoneCategoryDAO
    {
        private static PhoneCategoryDAO instance;
        public static int TableWidth = 80;
        public static int TabHeight = 80;

        public static PhoneCategoryDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PhoneCategoryDAO();
                }
                return instance;
            } 
            private set => instance = value;

        }

        public PhoneCategoryDAO() { }

        public List<PhoneCategoryDTO> LoadTableListPhoneCate()
        {
            List<PhoneCategoryDTO> tableList = new List<PhoneCategoryDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListPhoneCategory");

            foreach (DataRow item in data.Rows)
            {
                PhoneCategoryDTO phoneCate = new PhoneCategoryDTO(item);
                tableList.Add(phoneCate);
            }
            return tableList;
        }

        public PhoneCategoryDTO GetCategoryByIdPhone(int idPhone)
        {
            PhoneCategoryDTO category = null; //= new PhoneCategoryDTO(); haven't

            string query = string.Format("select * from PhoneCategory where idPhone = {0} " , idPhone);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new PhoneCategoryDTO(item);
                return category;
            }

            return category;
        }





    }
}
