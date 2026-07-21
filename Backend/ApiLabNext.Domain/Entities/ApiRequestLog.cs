namespace ApiLabNext.Domain.Entities
{
    public class ApiRequestLog
    {
        public string Method { get; set; }
        public string Path { get; set; }
        public int StatusCode { get; set; }
        public long Duration { get; set; }
        public DateTime Timestamp { get; set; }
    }   

}
