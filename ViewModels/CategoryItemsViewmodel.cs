using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.ViewModels
{
    public class CategoryItemsViewmodel :Item
    {
        public List<Item> items { get; set; }
        public List<Category> categories  { get; set; }

    }
}
