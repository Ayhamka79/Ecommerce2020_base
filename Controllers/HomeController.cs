using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ecommerce.Models;
using Ecommerce.ViewModels;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepositoy icategory;
        private readonly IItemRepository iitem;

        public HomeController(ILogger<HomeController> logger,ICategoryRepositoy Icategory,IItemRepository Iitem)
        {
            _logger = logger;
            icategory = Icategory;
            iitem = Iitem;
        }


        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                CategoryList = icategory.GetAllCategories(),
                ItemList = iitem.GetAllItems()
            };


            //var model = icategory.GetAllCategories();
            return View(homeViewModel);
        }

        public IActionResult test_item()
        {
         
            return View();
        }

        public IActionResult Profile()
        {

            return View();
        }
        // to get to instagram story
        public IActionResult InstaStory(int id)
        {

            List<Item> items = iitem.GetCategoryItems(id);
            ViewBag.ID = id;

            return View(items);
        }
        
        public IActionResult CategoryItems(int id,int page = 1)
        {
            CategoryItemsViewmodel categoryItemsViewmodel = new CategoryItemsViewmodel()
            {
                categories = icategory.GetAllCategories(),
                items = iitem.GetCategoryItems(id)
            };

            return View(categoryItemsViewmodel);

        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ItemDetails(int id)
        {
            var item = iitem.GetItem(id);
            return View(item);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
