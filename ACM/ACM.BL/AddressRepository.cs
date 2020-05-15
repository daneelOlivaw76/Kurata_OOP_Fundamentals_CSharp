using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int AddressId)
        {
            Address Address = new Address(AddressId);

            if(AddressId == 1)
            {
                Address.StreetLine1 = "Baggs End";
                Address.StreetLine2 = "Bagshot Row";
                Address.City = "Hobbiton";                
                Address.State = "Shire";                
                Address.Country = "Middle Earth";
                Address.PostalCode = "144";
                Address.AddressType = 1;
            }

            return Address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                StreetLine1 = "Baggs End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144",
                AddressType = 1,
            };

            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "142",
                AddressType = 2,
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address Address)
        {
            return true;
        }
    }
}
