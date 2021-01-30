using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public ICollection<Order> Orders { get; private set; }
    }
}
