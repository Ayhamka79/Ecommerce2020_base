using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
   public interface ICategoryRepositoy
    {
        Category GetCategory(int id);
        List<Category> GetAllCategories();
        Category AddCategory(Category category);
        Category UpdateCategory(Category categorychange);
        Category Delete(int id);
        //IEnumerable<SelectListItem> GetCategoriesNames();


    }
}
