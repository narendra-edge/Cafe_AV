 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cafe_AV.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafe_AV.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;
        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemsOfTheWeek = _itemRepository.ItemsOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}