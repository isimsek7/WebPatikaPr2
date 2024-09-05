using System;
using Microsoft.AspNetCore.Mvc;
using Web2.Models;

namespace Web2.Controllers
{
    public class CustomersController : Controller
    {

        public IActionResult Index()
        {
            // Basit bir model örneği oluşturuyoruz
            var customer = new Customer
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com"
            };
            List<Order> Orders = new List<Order>();
            Orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 999.99m, Quantity = 1 },
                new Order { Id = 2, ProductName = "Smartphone", Price = 499.99m, Quantity = 1 },
                new Order { Id = 3, ProductName = "Headphones", Price = 199.99m, Quantity = 2 },
                new Order { Id = 4, ProductName = "Monitor", Price = 299.99m, Quantity = 1 },
                new Order { Id = 5, ProductName = "Keyboard", Price = 99.99m, Quantity = 1 }
            };
          

            // ViewModel oluşturup view'a gönderiyoruz
            var viewModel = new CustomerViewModel
            {
                Customer = customer,
                Orders = Orders,
               
            };

            return View(viewModel);
        }
    }
}

