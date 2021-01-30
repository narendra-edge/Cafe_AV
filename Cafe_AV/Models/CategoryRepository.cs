using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafe_AV.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
     public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Categories;

        public Category GetCategoryById(int CategoryId)
        {
            return _appDbContext.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
        }
    }
    
   
}
