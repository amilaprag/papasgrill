namespace papasgrill.models
{
    public class Food
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
        public string? Price { get; set; }
        public int CategoryId { get; set; }
        public string? Category { get; set; }
        public string? ImageUrl { get; set; }
        public bool InStock { get; set; }
        public Tax? Tax { get; set; }
        public bool IsMeal { get; set; }
        public int AltFoodId { get; set; }
        public List<object>? FoodOptions { get; set; }
    }
}