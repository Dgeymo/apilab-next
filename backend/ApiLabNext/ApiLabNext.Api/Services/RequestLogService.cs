using ApiLabNext.Api.Models;

namespace ApiLabNext.Api.Services
{
    namespace ApiLabNext.Api.Services
    {
        public class RequestLogService
        {
            private readonly List<ApiRequestLog> _logs = new();
            private const int MaxLogs = 10000;
            public void Add(ApiRequestLog log)
            {
                if (_logs.Count >= MaxLogs)
                    _logs.RemoveAt(0);
                _logs.Add(log);
            }


            public IEnumerable<ApiRequestLog> GetAll()
            {
                return _logs;
            }
            public IEnumerable<ApiRequestLog> GetPageLog(int page = 1, int pageSize = 20)
            {
                return _logs
                    .OrderByDescending(l => l.Timestamp)
                    .Skip((page-1)*pageSize)
                    .Take(pageSize);
            }
        }
    }
}
