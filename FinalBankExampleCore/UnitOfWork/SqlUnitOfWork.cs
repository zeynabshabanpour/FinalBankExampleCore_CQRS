using FinalBankExampleCore.DataContext;

namespace FinalBankExampleCore.UnitOfWork
{
    public class SqlUnitOfWork : ISqlUnitOfWork
    {
        private readonly SQLDataContext sQLDataContext;
        public SqlUnitOfWork(SQLDataContext sQLDataContext)
        {
            this.sQLDataContext = sQLDataContext;
        }
        public void Commit()
        {
            sQLDataContext.SaveChanges();  
        }

        public void Dispose()
        {
            sQLDataContext.Dispose();
        }
    }
}
