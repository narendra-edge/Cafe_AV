using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemsOfTheWeek { get; set; }
    }
}
