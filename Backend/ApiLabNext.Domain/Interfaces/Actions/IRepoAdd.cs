
namespace ApiLabNext.Domain.Interfaces.Actions
{
    public interface IRepoAdd<T>
    {
        Task AddAsync(T item);
    }
}
