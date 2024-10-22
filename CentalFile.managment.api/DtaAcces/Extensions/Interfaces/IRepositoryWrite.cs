namespace CentalFile.managment.api.DtaAcces.Extensions.Interfaces
{
    public interface IRepositoryWrite<in T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        Task SaveChangesAsync();
    }

}
