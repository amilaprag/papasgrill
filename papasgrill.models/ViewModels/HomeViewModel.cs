namespace papasgrill.models.ViewModels
{
    public class HomeViewModel
    {
        public static HomeViewModel ToHomeViewModel(List<CategoryViewModel> categoryViewModels, List<FoodViewModel> foodViewModels)
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                FoodViewModels = foodViewModels,
                CategoryViewModels = categoryViewModels,
            };

            return homeViewModel;
        }

        public List<FoodViewModel>? FoodViewModels { get; set; }
        public List<CategoryViewModel>? CategoryViewModels { get; set; }
    }
}