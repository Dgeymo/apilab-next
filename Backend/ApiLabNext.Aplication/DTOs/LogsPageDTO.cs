
namespace ApiLabNext.Aplication.DTOs
{
    public record LogsPageDTO(IEnumerable<LogDTO> Logs,
                              int TotalCount,
                              int PageNumber,
                              int PageSize);
}
