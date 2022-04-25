using papasgrill.models;

namespace papasgrill.domain
{
    public interface ICategoryService
    {
        Task<List<Category>>? Categories(dynamic request);
    }
}