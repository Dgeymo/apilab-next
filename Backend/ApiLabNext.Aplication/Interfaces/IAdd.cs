
namespace ApiLabNext.Aplication.Interfaces
{
    public interface IAdd<T>
    {
        Task ExecuteAsync(T item);
    }
}
