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

        public Product Retrieve(int productId)
        {
            return new Product();
        }
    }
}
