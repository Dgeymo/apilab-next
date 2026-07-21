using ApiLabNext.Domain.Entities;
using ApiLabNext.Domain.Interfaces;

namespace ApiLabNext.Infraestructure.Repositories
{
    public class RepositoryLog : IRepositoryLog
    {
        private static readonly List<ApiRequestLog> _logs = new();
        private const int MaxLogs = 10000;
      
        public Task<(IEnumerable<ApiRequestLog> Items, int TotalCount)> GetWithPageAsync(int pageNumber, int pageSize)
        {
            return Task.FromResult((
                _logs
                   .OrderByDescending(l => l.Timestamp)
                   .Skip((pageNumber - 1) * pageSize)
                   .Take(pageSize),
                _logs.Count
            ));
        }

        public Task AddAsync(ApiRequestLog item)
        {
            if (_logs.Count >= MaxLogs)
                _logs.RemoveAt(0);
            _logs.Add(item);
            return Task.CompletedTask;
        }
    }
}
