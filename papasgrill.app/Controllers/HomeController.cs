using Microsoft.AspNetCore.Mvc;
using papasgrill.app.Models;
using papasgrill.domain;
using papasgrill.models;
using papasgrill.models.ViewModels;
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
            InitConfig initRequest = new()
            {
                UrlPath = "menu/food"
            };
            List<Food>? foods = await _food.Foods(initRequest);

            // getting category
            InitConfig categoryRequest = new()
            {
                UrlPath = "menu/webcategories"
            };
            List<Category>? categories = await _category.Categories(categoryRequest);
          
            return View(HomeViewModel.ToHomeViewModel(CategoryViewModel.ToCategoryViewModel(categories), FoodViewModel.ToFoodViewModel(foods)));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public PartialViewResult Foods([FromForm]List<FoodViewModel> foodViewModel,[FromForm]int categoryId)
        {
            var food = foodViewModel.Where(f => f.CategoryId == categoryId).ToList();
            return PartialView(food);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}