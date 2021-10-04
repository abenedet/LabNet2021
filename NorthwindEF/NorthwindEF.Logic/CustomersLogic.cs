using NorthwindEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindEF.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public Customers GetFirstOrNullCustomer()
        {
            return context.Customers.FirstOrDefault();
        }

        public List<Customers> GetCustomersByRegion(string region) 
        {
            var query = from customer in context.Customers
                        where customer.Region.Equals(region)
                        select customer;

            return query.ToList();
        }

        public List<string> GetCustomersNames(bool lowerCase) 
        {
            var customersList = context.Customers.Select(c => c.ContactName).ToList();

            List<string> customersNames = new List<string>();
            foreach (var customerName in customersList) 
            {
                if (lowerCase)
                {
                    customersNames.Add(customerName.ToLower());
                }
                else 
                {
                    customersNames.Add(customerName.ToUpper());
                }
            }

            return customersNames;        
        }

        public List<object> GetCustomerByRegionAndOrderGreaterThan(string region, DateTime date) 
        {
            var query = from customer in context.Customers
                        join order in context.Orders on customer.CustomerID.ToUpper() equals order.CustomerID.ToUpper()
                        where customer.Region.Equals(region) && order.OrderDate > date
                        select new                         
                        {
                            customer.CustomerID,
                            customer.Region,
                            order.OrderDate
                        };

            return query.ToList<object>();        
        }

        public List<Customers> GetCustomersByRegionAndFirstNumbers(string region, int number) 
        {
            return context.Customers.Where(c => c.Region.Equals(region)).Take(number).ToList();        
        }

    }
}
