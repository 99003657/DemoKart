using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class User
    {
        public String fName { get; set; }
        public String lName { get; set; }
        public int phoneNo { get; set; }

        public int Login(String UserName, String Password)
        {
            if (UserName == "user" && Password == "password")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}