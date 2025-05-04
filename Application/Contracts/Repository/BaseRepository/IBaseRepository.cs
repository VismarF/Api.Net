namespace Application.Contracts.Repository.BaseRepository
{
    public interface IBaseRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task<T?> GetByIdAsync(T id);
        Task<IEnumerable<T?>> GetAllAsync();
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
