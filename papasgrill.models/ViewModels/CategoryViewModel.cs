using papasgrill.models;

 namespace papasgrill.models.ViewModels
{
    public class CategoryViewModel
    {
        public static List<CategoryViewModel> ToCategoryViewModel(List<Category> categories)
        {
            List<CategoryViewModel> returnCategoryViewModels = new List<CategoryViewModel>();
            categories.ToList().ForEach(item =>
            {
                CategoryViewModel categoryViewModel = new CategoryViewModel
                {
                    Id = item.Id,
                    Category = item
                };
                returnCategoryViewModels.Add(categoryViewModel);
            });

            return returnCategoryViewModels;
        }

        public int Id { get; set; }
        public Category? Category { get; set; }
    }
}