using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class SQLItemRepository : IItemRepository
    {
        private readonly AppDbContext context;

        public SQLItemRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Item AddItem(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
            return item;

            throw new NotImplementedException();
        }

        public Item Delete(int id)
        {
            var item = context.Items.Find(id);
            if (item != null)
            {
                context.Items.Remove(item);
                context.SaveChanges();
            }
            throw new NotImplementedException();
        }

        public List<Item> GetAllItems()
        {
            return context.Items.ToList();
            throw new NotImplementedException();
        }

      

        public List<Item> GetCategoryItems(int categoryID)
        {

            // return context.Items.Where(e => e.CategoryID == categoryID).ToList();
            //(from i in _context.Categories where i.ID == categoryID select i).First();
            return (from i in context.Items where i.CategoryID == categoryID select i).ToList();
            throw new NotImplementedException();
        }

        public Item GetItem(int id)
        {
            return context.Items.Find(id);
            
            throw new NotImplementedException();
        }

        public Item UpdateItem(Item Itemchange)
        {
            var item = context.Items.Attach(Itemchange);
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Itemchange;
            throw new NotImplementedException();
        }
    }
}
