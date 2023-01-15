
namespace FinalBankExampleCore.UnitOfWork
{
    public interface ISqlUnitOfWork : IDisposable
    {
        public void Commit();
    }
}
