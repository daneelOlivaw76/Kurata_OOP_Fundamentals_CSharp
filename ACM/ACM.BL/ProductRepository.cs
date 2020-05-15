using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int ProductId)
        {
            Product Product = new Product(ProductId);

            if(ProductId == 2)
            {
                Product.ProductName = "Flowers";
                Product.ProductDescription = "Yellow sunflowers";
                Product.CurrentPrice = 39.99M;
            }

            return Product;
        }

        public bool Save(Product Product)
        {
            return true;
        }
    }
}
