using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
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

        public override string ToString() => this.ProductName;

        /// <summary>
        ///     Validates the Product data.
        /// </summary>
        /// <returns>
        ///     boolean Isvalid, if data is valid.
        /// </returns>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice != null && CurrentPrice < 0) isValid = false;

            return isValid;
        }
    }
}
