using System.Collections.Generic;
using System.Linq;

namespace ModernStore
{
    public class ProductRepository
    {
        public Product Get(int ID)
        {
            return products.SingleOrDefault(p => p.ID == ID);
        }

        public Product[] List()
        {
            return this.products.ToArray();
        }

        private List<Product> products = new List<Product>
        {
            new Product
            {
                ID = 1,
                Title = "Product 1",
            },
            new Product
            {
                ID = 2,
                Title = "Product 2",
            },
            new Product
            {
                ID = 3,
                Title = "Product 3",
            },
            new Product
            {
                ID = 4,
                Title = "Product 4",
            }
        };
    }
}
