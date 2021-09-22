using NorthwindEF.Data;
using NorthwindEF.Entities;

namespace NorthwindEF.Logic
{
    public class BaseLogic
    {
        protected readonly NorthwindContext context;
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
