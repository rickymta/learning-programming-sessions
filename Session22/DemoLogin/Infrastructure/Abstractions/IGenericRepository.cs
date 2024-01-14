namespace Infrastructure.Abstractions
{
    public interface IGenericRepository<T> where T : class
    {
        Task<long> CreateAsync(T entity);

        Task<T?> GetAsync(long id);

        Task<IEnumerable<T>?> GetAllAsync();

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(long id);
    }
}
