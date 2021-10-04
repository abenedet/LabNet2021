using NorthwindEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindEF.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAllProductsWithoutStock() 
        {
            var query = from product in context.Products
                        where product.UnitsInStock == 0
                        select product;

            return query.ToList();            
        }

        public List<Products> GetProductsWithStockAndPriceMoreThan(decimal price) 
        {
            return context.Products.Where(p => p.UnitPrice > price && p.UnitsInStock != 0).ToList();
        }

        public Products GetProductByID(int productID) 
        {
            return context.Products.Where(p => p.ProductID == productID).FirstOrDefault();
        }

        public List<Products> GetProductsOrderByName() 
        {
            var query = from product in context.Products
                        orderby product.ProductName
                        select product;

            return query.ToList();
        }

        public List<Products> GetProductsOrderByUnitStockDesc() 
        {
            return context.Products.OrderByDescending(p=> p.UnitsInStock).ToList();        
        }

        public Products GetFirstProduct() 
        {
            return context.Products.First();
        }
    }
}
