namespace ApiLabNext.Aplication.DTOs
{
    public record LogDTO(string Method,
                         string Path,
                         int StatusCode,
                         long Duration,
                         DateTime Timestamp)
    {
    }
}
