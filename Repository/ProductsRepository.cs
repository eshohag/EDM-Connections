using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    class ProductsRepository
    {
        public List<Product> GetProductsByCategory(int categoryId)
        {
            using (var context = new NorthwindSlimEntities())
            {
                var products = context.Products.Where(a => a.CategoryId == categoryId).OrderBy(a => a.ProductName).ToList();
                return products;
            }
        }
    }
}
