using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public  Item Item { get; set; }
        public  Order Order { get; set; }
    }
}
