using NorthwindEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindEF.Logic
{
    public class SuppliersLogic : BaseLogic
    {

        public List<Suppliers> GetSuppliersList()
        {
            return context.Suppliers.ToList();
        }
    }
}
