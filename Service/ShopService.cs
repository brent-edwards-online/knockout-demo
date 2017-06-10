namespace KnockoutDemo.Service
{
    using KnockoutDemo.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShopService : IShopService
    {
        ShopDbContext _context;

        public ShopService(ShopDbContext context)
        {
            _context = context;
        }

        public IList<Customer> GetCustomers(int? id)
        {
            if(id == null)
                return _context.Customers.ToList<Customer>();
            else
                return _context.Customers.Where(c => c.CustomerId == id).ToList<Customer>();
        }
    }
}
