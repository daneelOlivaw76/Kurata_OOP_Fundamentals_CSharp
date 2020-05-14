using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BLTest
{
    class Product
    {
        public Product() { }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        /// <summary>
        ///     Retrieves the Product per ProductId
        /// </summary>
        /// <param name="ProductId"></param>
        /// <returns>
        ///     Product.
        /// </returns>
        public Product Retrieve(int productId)
        {
            // Code that retrieves the product with specified productId.

            return new Product();
        }

        /// <summary>
        ///     Retrieves all products
        /// </summary>
        /// <returns>
        ///     All Products.
        /// </returns>
        public List<Product> Retrieve()
        {
            // Code that retrieves all products.

            return new List<Product>();
        }

        /// <summary>
        ///     Saves the Product data.
        /// </summary>
        /// <returns>
        ///     True, if data is saved.
        /// </returns>
        /// 
        public bool Save()
        {
            // Code that saves the defined Product

            return true;
        }

        /// <summary>
        ///     Validates the Product data.
        /// </summary>
        /// <returns>
        ///     boolean Isvalid, if data is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice != null && CurrentPrice < 0) isValid = false;

            return isValid;
        }
    }
}
