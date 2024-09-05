using System;
namespace Web2.Models
{
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<Order> Orders { get; set; }
    }
}

