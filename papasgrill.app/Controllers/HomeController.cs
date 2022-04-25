using Microsoft.AspNetCore.Mvc;
using papasgrill.app.Models;
using papasgrill.domain;
using papasgrill.models;
using System.Diagnostics;

namespace papasgrill.app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFoodService _food;
        private readonly ICategoryService _category;

        public HomeController(ILogger<HomeController> logger, IFoodService Food, ICategoryService Category)
        {
            _logger = logger;
            _food = Food;
            _category = Category;
        }

        public async Task<IActionResult> IndexAsync()
        {
            // getting foods
            InitConfig initRequest = new InitConfig();
            initRequest.UrlPath = "menu/food";
            List<Food>? foods = await _food.Foods(initRequest);

            // getting category
            InitConfig categoryRequest = new InitConfig();
            categoryRequest.UrlPath = "menu/webcategories";
            List<Category>? categories = await _category.Categories(categoryRequest);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}