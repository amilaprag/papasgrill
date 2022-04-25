namespace papasgrill.core.Request
{
    public interface IRequestService
    {
        public Task<dynamic?> RequestQueryAsync(dynamic configuration);
    }
}