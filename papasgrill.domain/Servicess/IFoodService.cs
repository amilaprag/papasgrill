using papasgrill.models;

namespace papasgrill.domain
{
    public interface IFoodService
    {
        Task<List<Food>>? Foods(dynamic request);
    }
}