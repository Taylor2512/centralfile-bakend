using CentalFile.managment.api.DtaAcces.Extensions.Interfaces;

namespace CentalFile.managment.api.DtaAcces.Extensions
{
    public class RepositoryWrite<T>(ApplicationDbContext context) : IRepositoryWrite<T> where T : class
    {

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            context.Set<T>().AddRange(entities);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            context.Set<T>().UpdateRange(entities);
        }
    }
}
