
namespace ApiLabNext.Domain.Interfaces.Actions
{
    public interface IRepoGetWithPage<T>
    {
        Task<(IEnumerable<T> Items, int TotalCount)> GetWithPageAsync(int pageNumber, int pageSize);
    }
}
