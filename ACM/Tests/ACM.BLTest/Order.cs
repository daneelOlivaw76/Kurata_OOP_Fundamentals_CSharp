using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BLTest
{
    class Order
    {
        public Order() { }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        /// <summary>
        ///     Retrieves the Order per OrderId
        /// </summary>
        /// <param name="OrderId"></param>
        /// <returns>
        ///     Order.
        /// </returns>
        public Order Retrieve(int OrderId)
        {
            // Code that retrieves the Order with specified OrderId.

            return new Order();
        }

        /// <summary>
        ///     Retrieves all Orders
        /// </summary>
        /// <returns>
        ///     All Orders.
        /// </returns>
        public List<Order> Retrieve()
        {
            // Code that retrieves all Orders.

            return new List<Order>();
        }

        /// <summary>
        ///     Saves the Order data.
        /// </summary>
        /// <returns>
        ///     True, if data is saved.
        /// </returns>
        /// 
        public bool Save()
        {
            // Code that saves the defined Order

            return true;
        }

        /// <summary>
        ///     Validates the Order data.
        /// </summary>
        /// <returns>
        ///     boolean Isvalid, if data is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

    }
}
