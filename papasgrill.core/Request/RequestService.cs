using System.Net.Http.Headers;

namespace papasgrill.core.Request
{
    public class RequestService : IRequestService
    {
        public async Task<dynamic?> RequestQueryAsync(dynamic configuration)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(configuration.BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(configuration.ContentType.ToString()));

                HttpResponseMessage response = await client.GetAsync(configuration.UrlPath);
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    Console.WriteLine("Internal server Error");
                }
            }
            return null;
        }
    }
}