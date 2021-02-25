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
        static List<Product> CartList = new List<Product>(20);

        static List<Product> ProductList = new List<Product>(20);
        public void Display(int id)
        {
            foreach(Product item in ProductList)
            {
                if(id==item.CategoryObj.categoriesId)
                {
                    Console.WriteLine("Product id : " + item.productId + "\nProduct Name : " + item.productName + "\nProduct Price : " + item.price + "\nProduct Quantity : " + item.quantity + "\nCategory Id : " + item.CategoryObj.categoriesId + "\nCategory Name : " + item.CategoryObj.categories);
                }
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Product[] ProductObj = new Product[20];
                for (int i = 0; i < 20; i++)
                {
                    ProductObj[0] = new Product(1, "TV", 7000, 5, 1, "Electronics");
                    ProductObj[1] = new Product(2, "MOBILE", 8000, 2, 1, "Electronics");
                    ProductObj[2] = new Product(3, "JUICER", 5000, 3, 1, "Electronics");
                    ProductObj[3] = new Product(4, "TOASTER", 5000, 4, 1, "Electronics");
                    ProductObj[4] = new Product(5, "LAPTOPS", 5000, 4, 1, "Electronics");

                    ProductObj[5] = new Product(11, "EGGS", 50, 14, 2, "Grocery");
                    ProductObj[6] = new Product(12, "MILK", 90, 4, 2, "Grocery");
                    ProductObj[7] = new Product(13, "OATS", 90, 4, 2, "Grocery");
                    ProductObj[8] = new Product(14, "BREAD", 130, 4, 2, "Grocery");
                    ProductObj[9] = new Product(15, "JAM", 190, 4, 2, "Grocery");

                    ProductObj[10] = new Product(6, "MUFFLER", 100, 4, 3, "Clothing");
                    ProductObj[11] = new Product(7, "CAP", 500, 4, 3, "Clothing");
                    ProductObj[12] = new Product(8, "SHIRT", 500, 4, 3, "Clothing");
                    ProductObj[13] = new Product(9, "PANT", 500, 4, 3, "Clothing");
                    ProductObj[14] = new Product(10, "SKIRT", 500, 4, 3, "Clothing");

                    ProductObj[15] = new Product(16, "LIPSTICK", 150, 4, 4, "Cosmetics");
                    ProductObj[16] = new Product(17, "EYELINER", 100, 3, 4, "Cosmetics");
                    ProductObj[17] = new Product(18, "FOUNDATION", 500, 2, 4, "Cosmetics");
                    ProductObj[18] = new Product(19, "FACE WIPES", 300, 4, 4, "Cosmetics");
                    ProductObj[19] = new Product(20, "FACE CREAM", 500, 3, 4, "Cosmetics");

                    ProductList.Add(ProductObj[i]);

                }

                Category CategoryObj = new Category();
                Cart CartObj = new Cart();
                Program programObj = new Program();

                Order OrderObj = new DemoKartBL.Order();
                Payment paymentObj = new Payment();
                int num, num1, num2, num3, num4, id;
                double TotalPrice = 0, totalPrice1 = 0, TotalPrice2 = 0, TotalPrice3 = 0, TotalPrice4 = 0;
                double GrandTotal1 = 0, GrandTotal2 = 0;
                User UserObj = new User();
                Console.WriteLine("*********************Welcome************************");
                Console.WriteLine("Enter User Name");
                String UserName = Console.ReadLine();
                Console.WriteLine("Enter Password");
                String Password = Console.ReadLine();
                int value = UserObj.Login(UserName, Password);

                if (value == 1)
                {
                    do
                    {
                        Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Cosmetics");
                        int Choice = Convert.ToInt32(Console.ReadLine());
                        if (Choice == 1)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\n2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter product ID you want to add  : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter The Quantity You Want");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Please Enter valid Quantity of the Product\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quant);
                                            totalPrice1 = totalPrice1 + TotalPric;
                                            Product userCart = new Product(item.productId, item.productName, item.price, quant, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(userCart);
                                            Console.WriteLine("Product Added To cart Is Successfully\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 2)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\n2.Continue\n");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID of the product you want to Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter the Quantity of the Product");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Please Enter valid Quantity of the Product\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quant);
                                            totalPrice1 = totalPrice1 + TotalPric;
                                            Product userCart = new Product(item.productId, item.productName, item.price, quant, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(userCart);
                                            Console.WriteLine("Product Added To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 3)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter Product Quantity You Want to add");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Please Enter valid Quantity of the Product\n");
                                            break;
                                        }
                                        else
                                        {
                                            double TotalPric = CategoryObj.CalculatePrice(Choice, item.price, quant);
                                            totalPrice1 = totalPrice1 + TotalPric;
                                            Product userCart = new Product(item.productId, item.productName, item.price, quant, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(userCart);
                                            Console.WriteLine("Product Added To cart Is Successfully\n");
                                        }

                                    }
                                }

                            }
                        }
                        if (Choice == 4)
                        {
                            programObj.Display(Choice);
                            Console.WriteLine("1.Add To Cart\t2.Continue");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 1)
                            {
                                Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\nEnter the no of Products You Want to add");
                                int quant = Convert.ToInt32(Console.ReadLine());
                                foreach (Product item in ProductList)
                                {
                                    if (id == item.productId)
                                    {
                                        value = CartObj.AddToCart(quant);
                                        if (value == 1)
                                        {
                                            Console.WriteLine("Please Enter valid Quantity of the Product\n");
                                            break;
                                        }
                                        else
                                        {
                                            double totalPrice = CategoryObj.CalculatePrice(Choice, item.price, quant);
                                            totalPrice1 = totalPrice1 + totalPrice;
                                            Product userCart = new Product(item.productId, item.productName, item.price, quant, item.CategoryObj.categoriesId, item.CategoryObj.categories);
                                            CartList.Add(userCart);
                                            Console.WriteLine("Add To cart Is Successfull\n");
                                        }

                                    }
                                }

                            }
                        }
                        Console.WriteLine("1.Revisit\t2.Display Cart And Payment");
                        num = Convert.ToInt32(Console.ReadLine());
                    } while (num == 1);
                }
                foreach (Product item in CartList)
                {

                    Console.WriteLine("Product id : " + item.productId);
                    Console.WriteLine("Product Name : " + item.productName);
                    Console.WriteLine("Product Price : " + item.price);
                    Console.WriteLine("Product Quantity : " + item.quantity);
                    Console.WriteLine("Product Quantity : " + item.CategoryObj.categoriesId);
                    Console.WriteLine("Product Quantity : " + item.CategoryObj.categories);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("1.Delete the Product List\t2.Order");
                num2 = Convert.ToInt32(Console.ReadLine());
                do
                {

                    if (num2 == 1)
                    {
                        Console.WriteLine("Enter The Product Id You Want To Delete");
                        int PI = Convert.ToInt32(Console.ReadLine());
                        foreach (Product item in CartList)
                        {
                            if (PI == item.productId)
                            {
                                CartList.Remove(item);
                                Console.WriteLine("Cart item" + PI + "Deleted");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Item is not available in Cart");
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }

                    Console.WriteLine("1.Remove Another Cart\t2.Order");
                    num3 = Convert.ToInt32(Console.ReadLine());
                } while (num3 == 1);

                foreach (Product item in CartList)
                {
                    Console.WriteLine("Updated Cart List");
                    Console.WriteLine("Product id : " + item.productId);
                    Console.WriteLine("Product Name : " + item.productName);
                    Console.WriteLine("Product Price : " + item.price);
                    Console.WriteLine("Product Quantity : " + item.quantity);
                    Console.WriteLine("Product Quantity : " + item.CategoryObj.categoriesId);
                    Console.WriteLine("Product Quantity : " + item.CategoryObj.categories);
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Enter User Details To Complete Order");
                Console.WriteLine("Enter Your First Name : ");
                OrderObj.firstName = Console.ReadLine();
                Console.WriteLine("Enter  Your Last Name : ");
                OrderObj.lastName = Console.ReadLine();
                Console.WriteLine("Enter Phone No : ");
                OrderObj.mobileNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Delivery Address : ");
                OrderObj.deliveryAddress = Console.ReadLine();


                TotalPrice = totalPrice1 + TotalPrice2 + TotalPrice3 + TotalPrice4;

                Console.WriteLine("Choose The Payment Method");
                Console.WriteLine("1.ByCash\t2.ByCard");
                num4 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Order  Placed ..................");
                Console.WriteLine("First Name : " + OrderObj.firstName + "\nLast Name : " + OrderObj.lastName + "\nMobile Number : " + OrderObj.mobileNo + "\nDelivery Address : " + OrderObj.deliveryAddress);
                if (num4 == 1)
                {
                    GrandTotal1 = paymentObj.CalcCGST(num4, TotalPrice);
                    Console.WriteLine("Central GST is : " + GrandTotal1);
                    GrandTotal2 = paymentObj.CalcSGST(num4, TotalPrice);
                    Console.WriteLine("State GST is : " + GrandTotal2);
                }
                else if (num4 == 2)
                {
                    double GrandTotal3 = paymentObj.CalcCGST(num4, TotalPrice);
                    Console.WriteLine("Central GST is : " + GrandTotal3);
                    double GrandTotal4 = paymentObj.CalcSGST(num4, TotalPrice);
                    Console.WriteLine("State GST is : " + GrandTotal4);
                }
                else
                {
                    Console.WriteLine("Enter Correct Choice");
                }

                Console.WriteLine("Thank You");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); 
            }

        }
    }
}

