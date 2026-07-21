using ApiLabNext.Aplication.DTOs;
using ApiLabNext.Aplication.Interfaces;
using ApiLabNext.Aplication.Mappers;
using ApiLabNext.Domain.Interfaces;

namespace ApiLabNext.Aplication.UseCases
{
    public class AddLog(IRepositoryLog _repoLog):IAdd<LogDTO>
    {
        public async Task ExecuteAsync(LogDTO item)
        {
           await _repoLog.AddAsync(LogMapper.ToEntity(item));
        }
    }
}
