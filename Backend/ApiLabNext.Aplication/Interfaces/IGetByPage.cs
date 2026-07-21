namespace ApiLabNext.Aplication.Interfaces
{
    public interface IGetByPage<T>
    {
        Task<T> ExecuteAsync(int pageNumber, int pageSize);
    }
}
