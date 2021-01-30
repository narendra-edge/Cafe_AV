﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafe_AV.Models;
using Cafe_AV.ViewModels;

namespace Cafe_AV.Controllers
{
    [Route("api/[controller]")]
    public class ItemDataController : Controller
    {
        private readonly IItemRepository _itemRepository;
        
        public ItemDataController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet]
        public IEnumerable<ItemViewModel> LoadMoreItems()
        {
            IEnumerable<Item> dbItems = null;
            dbItems = _itemRepository.Items.OrderBy(p => p.ItemId).Take(10);
            List<ItemViewModel> items = new List<ItemViewModel>();
            foreach (var dbItem in dbItems)
            {
                items.Add(MapDbItemToItemViewModel(dbItem));
            }
            return items;
        }

        private ItemViewModel MapDbItemToItemViewModel(Item dbItem)
        {
            return new ItemViewModel()
            {
                ItemId = dbItem.ItemId,
                Name = dbItem.Name,
                Price = dbItem.Price,
                Discount = dbItem.Discount,
                Quantity = dbItem.Quantity,
                AllergyInformation = dbItem.AllergyInformation,
                ShortDescription = dbItem.shortDescription,
                ImageThumbnailUrl = dbItem.ImageThumbnailUrl
            };
        }
    }
}
