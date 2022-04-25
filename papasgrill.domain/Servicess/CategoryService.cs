using Newtonsoft.Json;
using papasgrill.core.Request;
using papasgrill.models;

namespace papasgrill.domain
{
    public class CategoryService : ICategoryService
    {
        private readonly IRequestService _request;

        public CategoryService(IRequestService Request)
        {
            _request = Request;
        }

        public async Task<List<Category>>? Categories(dynamic request)
        {
            try
            {
                var response = await _request.RequestQueryAsync(request);
                List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(response);
                return categories;
            }
            catch (Exception message)
            {
                Console.WriteLine(message);
                throw;
            }
        }
    }
}