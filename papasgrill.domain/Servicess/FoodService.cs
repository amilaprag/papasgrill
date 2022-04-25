using Newtonsoft.Json;
using papasgrill.core.Request;
using papasgrill.models;

namespace papasgrill.domain
{
    public class FoodService : IFoodService
    {
        private readonly IRequestService _request;

        public FoodService(IRequestService Request)
        {
            _request = Request;
        }

        public async Task<List<Food>> Foods(dynamic request)
        {
            try
            {
                var response = await _request.RequestQueryAsync(request);
                List<Food> foods = JsonConvert.DeserializeObject<List<Food>>(response);
                return foods;
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
                throw;
            }
        }
    }
}