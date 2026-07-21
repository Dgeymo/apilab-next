
using ApiLabNext.Aplication.DTOs;
using ApiLabNext.Domain.Entities;

namespace ApiLabNext.Aplication.Mappers
{
    public class LogMapper
    {
        public static LogsPageDTO ToLogPageDTO(IEnumerable<ApiRequestLog> requestLogs,
                                               int totalCount,
                                               int pageNumber,
                                               int pageSize)
        {
            return new LogsPageDTO(ToLogDTOList(requestLogs),
                                   totalCount,
                                   pageNumber,
                                   pageSize);
        }
        public static LogDTO ToLogDTO(ApiRequestLog log)
        {
            return new(log.Method,
                       log.Path,
                       log.StatusCode,
                       log.Duration,
                       log.Timestamp);
        }
        public static IEnumerable<LogDTO> ToLogDTOList(IEnumerable<ApiRequestLog> logs)
        {
            return logs.Select(log => ToLogDTO(log));
        }

        public static ApiRequestLog ToEntity(LogDTO item)
        {
            return new ApiRequestLog
            {
                Method = item.Method,
                Path = item.Path,
                StatusCode = item.StatusCode,
                Duration = item.Duration,
                Timestamp = item.Timestamp
            };
        }
    }
}
