using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
        IEnumerable<Item> ItemsOfTheWeek { get; }
        Item GetItemById(int itemId);
        Item Add(Item item);
    }
}
