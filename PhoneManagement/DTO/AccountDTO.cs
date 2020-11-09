using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagement.DTO
{
    public class AccountDTO
    {
        private string userName;
        private string disPlayName;
        private string passWord;
        private int type;

        public string UserName { get => userName; set => userName = value; }
        public string DisPlayName { get => disPlayName; set => disPlayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }

        public AccountDTO(string userName, string disPlayName, int type, string passWord = null)
        {
            this.UserName = userName;
            this.DisPlayName = disPlayName;
            this.PassWord = passWord;
            this.Type = type;

        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisPlayName = row["displayName"].ToString();
            this.PassWord = row["passWord"].ToString();
            this.Type = (int)row["type"];
        }
    }
}
