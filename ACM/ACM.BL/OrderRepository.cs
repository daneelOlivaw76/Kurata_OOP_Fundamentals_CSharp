using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public Order Retrieve(int OrderId)
        {
            Order Order = new Order(OrderId);

            if(OrderId == 10)
            {
                Order.CustomerId = 1;
                Order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7,0,0));
                //Order.ShippingAddress = "Hobbiton, Baggs End";
            }

            return Order;
        }

        public bool Save(Order Order)
        {
            return true;
        }
    }
}
