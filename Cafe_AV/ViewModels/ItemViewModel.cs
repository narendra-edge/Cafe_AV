using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.ViewModels
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public decimal Price { get; set; }
        public decimal Discount {get; set;}
        public string Quantity {get; set;}
        public string AllergyInformation { get; set; }
        public string ImageThumbnailUrl { get; set; }
        
    }
}

