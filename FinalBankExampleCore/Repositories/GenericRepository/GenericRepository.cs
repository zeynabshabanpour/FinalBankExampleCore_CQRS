using FinalBankExampleCore.DataContext;
using Microsoft.EntityFrameworkCore;

namespace FinalBankExampleCore.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, new()
    {
        private readonly SQLDataContext dataContext;
        private DbSet<TEntity> _table { get; set; }
        public GenericRepository(SQLDataContext dataContext)
        {
            this.dataContext = dataContext;
            _table = dataContext.Set<TEntity>();
        }

        public TEntity GetEntityByID(int entityID)
        {
            return _table.Find(entityID);
        }

        public List<TEntity> GetAllEntity()
        {
            return _table.ToList();
        }

        public bool SaveEntity(TEntity entity)
        {
            try
            {
                _table.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public TEntity UpdateEntity(TEntity entity)
        {
            try
            {
                _table.Update(entity);
                return entity;
            }
            catch
            {
                return new TEntity();
            }

        }

        public bool DeleteEntity(int entityID)
        {
            try
            {
                var entity = GetEntityByID(entityID);
                _table.Remove(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
