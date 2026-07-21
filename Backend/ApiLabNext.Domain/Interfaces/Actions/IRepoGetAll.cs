
namespace ApiLabNext.Domain.Interfaces.Actions
{
    public interface IRepoGetAll<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
    }
}
