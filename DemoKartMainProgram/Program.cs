using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKartMainProgram
{
    class Program
    {


        static void Main(string[] args)
        {


            User UserObj = new User();
            Console.WriteLine("************************Welcome*****************************");
            Console.WriteLine("Enter your User name");
            String UserName = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            String Password = Console.ReadLine();
            int value = UserObj.Login(UserName, Password);
            Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Cosmetics");
            int Choice = Convert.ToInt32(Console.ReadLine());

        }
    }
}