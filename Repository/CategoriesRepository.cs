using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    class CategoriesRepository
    {
        public List<Category> GetCategories()
        {
            using (var context = new NorthwindSlimEntities())
            {
                var categories = context.Categories.OrderBy(a => a.CategoryId).ToList();
                return categories;
            }
        }
    }
}
