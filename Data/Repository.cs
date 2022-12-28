using System.Linq.Expressions;
using WebApplication3.Data;

namespace WebApplication3.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext context;

        public Repository()
        {
            this.context = UniversityContext.Instantiate_UniversityContext(); ;
        }

        public bool Add(TEntity Entity)
        {
            try
            {
                this.context.Set<TEntity>().Add(Entity);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool AddRange(IEnumerable<TEntity> entity)
        {
            try
            {
                this.context.Set<TEntity>().AddRange(entity);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.context.Set<TEntity>().Where(predicate).ToList();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return this.context.Set<TEntity>().Find(id);
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                this.context.Set<TEntity>().Remove(entity);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool RemoveRange(IEnumerable<TEntity> entity)
        {
            try
            {
                this.context.Set<TEntity>().RemoveRange(entity);
                this.context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
