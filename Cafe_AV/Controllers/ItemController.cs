using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafe_AV.Models;
using Cafe_AV.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Cafe_AV.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHostingEnvironment _hostingEnvironment;
        public ItemController(IItemRepository itemRepository, 
                              ICategoryRepository categoryRepository,
                              IHostingEnvironment  hostingEnvironment)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Item> Items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                Items = _itemRepository.Items.OrderBy(p => p.ItemId);
                currentCategory = "All Items";
            }
            else
            {
                Items = _itemRepository.Items.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.ItemId);
                currentCategory = _categoryRepository.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }
            return View(new ItemsListViewModel
            {
                Items = Items,
                CurrentCategory = currentCategory
            });
        }
        public ViewResult  Details(int itemId)
        {
            Item item = _itemRepository.GetItemById(itemId);
            
            if (item == null)
            {
                Response.StatusCode = 404;
                return View ("ItemNotFound", itemId);
            }
            ItemDetailsViewModel itemDetailsViewModel = new ItemDetailsViewModel() 
            {
                Item = item,
                PageTitle = "Item Details"
            }; 

            return View(itemDetailsViewModel);
        }
        [HttpGet]
        public ViewResult CreateItem()
        {
            return View();
        }
        private string ProcessUploadedFile(ItemCreateViewModel model)
        {
            string uniqueFileName = null;
            if (model.ImageUrl != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageUrl.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageUrl.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
        [HttpPost]
        public IActionResult CreateItem(ItemCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = ProcessUploadedFile(model);

                Item newItem = new Item
                {
                    Category = model.Category,
                    Name = model.Name,
                    shortDescription = model.shortDescription,
                    LongDescription = model.LongDescription,
                    AllergyInformation = model.AllergyInformation,
                    Price = model.Price,
                    Discount = model.Discount,
                    Size = model.Size,
                    Quantity = model.Quantity,
                    UnitsInOrder = model.UnitsInOrder,
                    isItemOfTheWeek = model.isItemOfTheWeek,
                    InStock = model.InStock,
                    Customise = model.Customise,
                    CustomisedType = model.CustomisedType,
                    CustomisedOption = model.CustomisedOption,
                    Discontinued = model.Discontinued
                };

                _itemRepository.Add(newItem);
                return RedirectToAction("Details", new { id = newItem.ItemId });
            }
            return View();
        }
    }
}
