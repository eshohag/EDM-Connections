using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    class ProductRepositories
    {
        public List<Product> GatProductByCategoriesId(int categoryId)
        {
            using (var context = new NorthwindSlimEntities())
            {
                var products = (from p in context.Products
                                where p.CategoryId == categoryId
                                orderby p.ProductName
                                select p).ToList();
                return products;
            }
        }
    }
}
