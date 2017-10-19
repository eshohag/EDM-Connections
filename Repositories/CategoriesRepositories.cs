using System.Collections.Generic;
using System.Linq;

namespace Repositories
{
    class CategoriesRepositories
    {
        public List<Category> Categories()
        {
            using (var context = new NorthwindSlimEntities())
            {
                var categories = context.Categories.OrderBy(a => a.CategoryId).ToList();
                return categories;
            }
        }
    }
}
