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
        static List<Product> ProductList1 = new List<Product>(10);
        static List<Product> ProductList2 = new List<Product>(10);
        static List<Product> ProductList3 = new List<Product>(10);
        static List<Product> ProductList4 = new List<Product>(10);
        static List<Product> CartList = new List<Product>(10);
        
        static void Main(string[] args)
        {
            
            Product[] ProductObj = new Product[20];
            Cart CartObj = new Cart();
            Category categoryObj = new Category();
            Payment paymentObj = new Payment();
            int num,num1,num3,num4,id;
            User UserObj = new User();
            Console.WriteLine("Welcome");
            Console.WriteLine("Enter User name");
            String UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            String Password = Console.ReadLine();
            int value = UserObj.Login(UserName, Password);
            for (int i = 0; i < 5; i++)
            {
                ProductObj[0] = new Product(1, "APPLE", 5000, 7);
                ProductObj[1] = new Product(2, "ONEPLUS", 7000, 6);
                ProductObj[2] = new Product(3, "SAMSUNG", 7000, 6);
                ProductObj[3] = new Product(4, "OPPO", 7000, 6);
                ProductObj[4] = new Product(5, "VIVO", 7000, 6);
                ProductList1.Add(ProductObj[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                ProductObj[0] = new Product(6, "EGGS", 50, 15);
                ProductObj[1] = new Product(7, "BREAD", 60, 4);
                ProductObj[2] = new Product(8, "MILK", 60, 7);
                ProductObj[3] = new Product(9, "OATS", 160, 2);
                ProductObj[4] = new Product(10, "JAM", 160, 3);

                ProductList2.Add(ProductObj[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                ProductObj[0] = new Product(11, "USPA", 1550, 6);
                ProductObj[1] = new Product(12, "NIKE", 1700, 4);
                ProductObj[2] = new Product(13, "PUMA", 700, 4);
                ProductObj[3] = new Product(14, "ADIDAS", 700, 4);
                ProductObj[4] = new Product(15, "SUPERDRY", 1170, 4);

                ProductList3.Add(ProductObj[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                ProductObj[0] = new Product(16, "BACARDI LEMON", 600, 5);
                ProductObj[1] = new Product(17, "BEERA", 130, 8);
                ProductObj[2] = new Product(18, "ROYAL SALUTE", 25000, 3);
                ProductObj[3] = new Product(19, "JOHNNIE WALKER", 1550, 4);
                ProductObj[4] = new Product(20, "ABSOULTE VODKA", 1300, 3);

                ProductList4.Add(ProductObj[i]);
            }

            if (value == 1)
            {

                do
                {
                    Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Beverages");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    if (Choice == 1)
                    {
                      
                        foreach (Product item in ProductList1)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if(num1==1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            //dfcgvhbjnkml
                           
                        }
    
                    }








                    else if(Choice==2)
                    {
                        foreach (Product item in ProductList2)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            
                        }

                    }
                
                    else if(Choice==3)
                    {
                        foreach (Product item in ProductList3)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                            
                        }
                    }
                    else if(Choice==4)
                    {
                        
                        foreach (Product item in ProductList4)
                        {

                            Console.WriteLine("Product id : " + item.productId);
                            Console.WriteLine("Product Name : " + item.productName);
                            Console.WriteLine("Product Price : " + item.price);
                            Console.WriteLine("Product Quantity : " + item.quantity);
                            Console.WriteLine("\n");
                        }
                        Console.WriteLine("1.Add To Cart\t2.Continue");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nEnter How Many Quantity You Want");
                            int quant = Convert.ToInt32(Console.ReadLine());
                           
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                    Console.WriteLine("1.Revisit\t2.Display Cart And Payment");
                    num = Convert.ToInt32(Console.ReadLine());

                } while (num==1);
            }
            else
            {
                Console.WriteLine("User Name and Passwords are Not matched\n");
            }


            foreach (Product item in CartList)
            {

                Console.WriteLine("Product id : " + item.productId);
                Console.WriteLine("Product Name : " + item.productName);
                Console.WriteLine("Product Price : " + item.price);
                Console.WriteLine("Product Quantity : " + item.quantity);
                Console.WriteLine("\n");
            }

        }
    }
}
