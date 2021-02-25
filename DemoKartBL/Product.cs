using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Product
    {
        public int productId { get; set; }
        public String productName { get; set; }
        public int quantity { get; set; }
        public double price { get; set; }
        
        public Category CategoryObj = new Category();
        public Product()
        {
            productId = 0;
            productName = null;
            quantity = 0;
            price = 0;
        }
        public Product(int pId, String pName, double pPrice, int pQuantity,int CategoriesId,String Categories)
        {
            this.productId = pId;
            this.productName = pName;
            this.quantity = pQuantity;
            this.price = pPrice;
            CategoryObj.categoriesId = CategoriesId;
            CategoryObj.categories = Categories;
        }
    }
}
