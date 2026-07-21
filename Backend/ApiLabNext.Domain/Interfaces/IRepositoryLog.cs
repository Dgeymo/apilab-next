
using ApiLabNext.Domain.Entities;
using ApiLabNext.Domain.Interfaces.Actions;

namespace ApiLabNext.Domain.Interfaces
{
    public interface IRepositoryLog: IRepoAdd<ApiRequestLog>,
                                     IRepoGetWithPage<ApiRequestLog>                                     
    {
    }
}
