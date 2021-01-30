using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class Category
    {
        public Category()
        {
            Items = new HashSet<Item>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool Discontinued { get; set; }
        public byte[] Picture { get; set; }
        public ICollection<Item> Items { get; private set; }
    }
}
