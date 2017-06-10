namespace KnockoutDemo.Service
{
    using KnockoutDemo.Entities;
    using System.Collections.Generic;

    public interface IShopService
    {
        IList<Customer> GetCustomers(int? id);
    }
}
