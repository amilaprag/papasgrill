namespace papasgrill.models
{
    public class BaseCoinfig
    {
        public BaseCoinfig()
        {
            Id = Guid.NewGuid();
            ContentType = "application/json";
            DateTime = DateTimeOffset.UtcNow;
        }

        public Guid Id { get; set; }
        public DateTimeOffset? DateTime { get; set; }
        public string? ContentType { get; set; }
        public string? UrlPath { get; set; }
    }
}