using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace ACM.BL
{
    public class Customer
    {
        public Customer() { }

        public Customer(int customerId)
        {
            CustomerId = customerId;
        }

        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }

                return fullName; 
            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        /// <summary>
        ///     Retrieves the customer per customerId
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns>
        ///     Customer.
        /// </returns>
        public Customer Retrieve(int customerId)
        {
            // Code that retrieves the customer with specified customerId.

            return new Customer();
        }

        /// <summary>
        ///     Retrieves customer per customerId
        /// </summary>
        /// <returns>
        ///     All Customers.
        /// </returns>
        public List<Customer> Retrieve()
        {
            // Code that retrieves all customers.

            return new List<Customer>();
        }

        /// <summary>
        ///     Saves the customer data.
        /// </summary>
        /// <returns>
        ///     True, if data is saved.
        /// </returns>
        /// 
        public bool Save()
        {
            // Code that saves the defined customer

            return true;
        }

        /// <summary>
        ///     Validates the customer data.
        /// </summary>
        /// <returns>
        ///     boolean Isvalid, if data is valid.
        /// </returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
