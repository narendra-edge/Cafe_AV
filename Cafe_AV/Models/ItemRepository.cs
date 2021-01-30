using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;
        
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Item> Items
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category);
            }

        }
        public IEnumerable<Item> ItemsOfTheWeek
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category).Where(i => i.isItemOfTheWeek);
            }
        }

        public Item Add(Item item)
        {
            _appDbContext.Items.Add(item);
            _appDbContext.SaveChanges();
            return item;
        }

        public Item GetItemById(int ItemId)
        {
            return _appDbContext.Items.FirstOrDefault(i => i.ItemId == ItemId);
        }
    }
}
