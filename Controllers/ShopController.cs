namespace KnockoutDemo.Controllers
{
    using KnockoutDemo.Entities;
    using KnockoutDemo.Service;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class ShopController: Controller
    {
        private IShopService _service;

        public ShopController(IShopService service)
        {
            _service = service;
        }

        [HttpGet("customers/{id?}")]
        public IEnumerable<Customer> GetCustomers(int? id)
        {
            return _service.GetCustomers(id);
        }
        
    }
}
