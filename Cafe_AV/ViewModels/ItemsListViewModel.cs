using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe_AV.Models;

namespace Cafe_AV.ViewModels
{
    public class ItemsListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string CurrentCategory { get; set; }
    }
}