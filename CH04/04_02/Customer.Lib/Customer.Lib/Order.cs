using System;
using System.Collections.Generic;
using System.Text;

namespace Customer.Lib
{
    public class Order
    {
        public Guid Id { get; set; }
        public List<Product> Products { get; set; }
        public Customer Customer { get; set; }
        public decimal Total { get; set; }
        public decimal Taxes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
