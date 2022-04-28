namespace papasgrill.models.ViewModels
{
    public class FoodViewModel
    {
        public static List<FoodViewModel> ToFoodViewModel(List<Food> foods)
        {
            List<FoodViewModel> returnFoodViewModels = new List<FoodViewModel>();
            foods.ToList().ForEach(item =>
            {
                FoodViewModel foodViewModel = new FoodViewModel
                {
                    CategoryId = item.CategoryId,
                    Food = item
                };
                returnFoodViewModels.Add(foodViewModel);
            });

            return returnFoodViewModels;
        }

        public int CategoryId { get; set; }
        public Food? Food { get; set; }
    }
}