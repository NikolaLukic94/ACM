using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Product Retrieve(int productId)
        {
            return new Product();
        }
    }
}
