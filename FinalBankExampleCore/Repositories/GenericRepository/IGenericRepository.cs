namespace FinalBankExampleCore.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity GetEntityByID(int entityID);
        List<TEntity> GetAllEntity();
        bool SaveEntity(TEntity entity);
        TEntity UpdateEntity(TEntity entity);
        bool DeleteEntity(int entityID);
    }
}
