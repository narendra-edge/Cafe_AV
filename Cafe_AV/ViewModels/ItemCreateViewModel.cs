using Cafe_AV.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.ViewModels
{
    public class ItemCreateViewModel
    {
        public int ItemId { get; set; }
        [Required]
        public string Name { get; set; }
        public string shortDescription { get; set; }
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Quantity { get; set; }
        public Size? Size { get; set; }
        public short? UnitsInOrder { get; set; }
        public IFormFile ImageUrl { get; set; }
        public IFormFile ImageThumbnailUrl { get; set; }
        public bool isItemOfTheWeek { get; set; }
        [Required]
        public bool InStock { get; set; }
        public bool Customise { get; set; }
        public CustomisedType? CustomisedType { get; set; }
        public string CustomisedOption { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public virtual Category Category { get; set; }
    }
}
