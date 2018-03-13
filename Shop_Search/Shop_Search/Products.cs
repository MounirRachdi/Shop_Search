using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Search
{
    public class Products
    {
         //products;
        public List<Product> GetProducts()
        {
         List<Product> products = new List<Product>
            {
                new Product
                {
                    name="Gucci Hand Bag Light Brown",
                    description="Almost New",
                    price="3000.00 SAR",
                    ImgUrl="sac1.png"
                },
                new Product
                {
                    name="Gucci Hand Bag Light Brown",
                    description="Almost New",
                    price="3000.00 SAR",
                    ImgUrl="sac2.png"
                },
                new Product
                {
                    name="Gucci Hand Bag Light Brown",
                    description="Almost New",
                    price="3000.00 SAR",
                    ImgUrl="image3.png"
                }
            };
            return products;



        }
    }
}
