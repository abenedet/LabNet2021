using NorthwindEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindEF.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<Categories> GetDistinctCategories() 
        {
            return context.Categories.Distinct().ToList();   
        }
    }
}
