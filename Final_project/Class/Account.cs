using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project.Class
{
    public class Account
    {
        private string userName = "";
        private string password = "";
        private string accountId = "";
        private string role = "";

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public Account(string userName, string passWord)
        {
            this.UserName = userName;
            this.Password = passWord;
        }
      
        public string AccountId { get => accountId; set => accountId = value; }
        public string Role { get => role; set => role = value; }

        public Account(string accountId, string username, string pass, string role)

        {
            this.accountId = accountId;
            this.userName = username;
            this.password = pass;
            this.Role = role;
        }

        public Account() { }
    }
}
