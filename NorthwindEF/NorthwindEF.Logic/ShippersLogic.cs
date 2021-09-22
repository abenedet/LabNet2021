using NorthwindEF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindEF.Logic
{
    public class ShippersLogic : BaseLogic
    {
        public void Add(Shippers newShipper) 
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();
        }

        public void Update(Shippers shipper) 
        {
            var shipperUpdate = context.Shippers.Find(shipper.ShipperID);
            shipperUpdate.CompanyName = shipper.CompanyName;
            shipperUpdate.Phone = shipper.Phone;

            context.SaveChanges();        
        }

        public void Delete(int idShipper) 
        {
            var shipperAEliminar = context.Shippers.Find(idShipper);
            context.Shippers.Remove(shipperAEliminar);
            context.SaveChanges();
        }

        public List<Shippers> GetShipperList() 
        {
            return context.Shippers.ToList();        
        }
    }
}
