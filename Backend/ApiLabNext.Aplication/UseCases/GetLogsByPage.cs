using ApiLabNext.Aplication.DTOs;
using ApiLabNext.Aplication.Interfaces;
using ApiLabNext.Aplication.Mappers;
using ApiLabNext.Domain.Entities;
using ApiLabNext.Domain.Interfaces;

namespace ApiLabNext.Aplication.UseCases
{
    public class GetLogsByPage(IRepositoryLog _repoLog) : IGetByPage<LogsPageDTO>
    {
        public async Task<LogsPageDTO> ExecuteAsync(int pageNumber, int pageSize)
        {
            if (pageNumber <= 0) pageNumber = 1;
            if (pageSize <= 0) pageSize = 10;
            (IEnumerable<ApiRequestLog> items, int totalCount) = await _repoLog.GetWithPageAsync(pageNumber, pageSize);

            return LogMapper.ToLogPageDTO(items, totalCount, pageNumber, pageSize);
        }
    }
}
