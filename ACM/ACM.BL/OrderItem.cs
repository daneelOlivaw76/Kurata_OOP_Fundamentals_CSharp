using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem() { }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public List<OrderItem> Retrieve(int productId)
        {
            // Code that retrieves the order item with specified productId.

            return new List<OrderItem>();
        }

        /// <summary>
        ///     Retrieves all order items
        /// </summary>
        /// <returns>
        ///     All Customers.
        /// </returns>
        public List<OrderItem> Retrieve()
        {
            // Code that retrieves all order items.

            return new List<OrderItem>();
        }

        /// <summary>
        ///     Saves the order item data.
        /// </summary>
        /// <returns>
        ///     True, if data is saved.
        /// </returns>
        /// 
        public bool Save()
        {
            // Code that saves the defined order item

            return true;
        }

        /// <summary>
        ///     Validates the order item data.
        /// </summary>
        /// <returns>
        ///     boolean Isvalid, if data is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice != null && PurchasePrice < 0) isValid = false;

            return isValid;
        }
    }
}
