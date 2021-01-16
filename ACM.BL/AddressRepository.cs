using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Test st 1";
                address.StreetLine2 = "Test st 2";
                address.City = "Paracin";
                address.State = "Srb";
                address.Country = "Middle Earth";
                address.PostalCode = "55520";
            }

            return address;
        }

        // returns sequence of data
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "New Test St 1",
                StreetLine2 = "New Test St 2",
                City = "Test City",
                State = "Ja",
                Country = "Middle East",
                PostalCode = "12345"
            };

            addressList.Add(address);

            address = new Address(1)
            {
                AddressType = 12,
                StreetLine1 = "New Test St 11",
                StreetLine2 = "New Test St 22",
                City = "Test City 2",
                State = "Ja 2",
                Country = "Middle East 2",
                PostalCode = "123452"
            };

            addressList.Add(address);

            return addressList;
        }
    }
}
