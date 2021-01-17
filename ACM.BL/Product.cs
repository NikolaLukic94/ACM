using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductId { get; private set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                // calling static method
                return StringHandler.InsertSpaces(_productName);
            }
            set
            {
                _productName = value;
            }
        }


        public Product Retrieve(int productId)
        {
            return new Product();
        }
    }
}
