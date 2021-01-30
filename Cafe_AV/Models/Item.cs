using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class Item
    {
        public Item()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string shortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Quantity { get; set; }
        public Size? Size { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool isItemOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public short? UnitsInOrder { get; set; }
        public bool Customise { get; set; }
        public CustomisedType? CustomisedType { get; set; }
        public string CustomisedOption { get; set;}
        public bool Discontinued { get; set; }
        public int? CategoryId { get; set; }
        public  Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; private set; }

    }
}