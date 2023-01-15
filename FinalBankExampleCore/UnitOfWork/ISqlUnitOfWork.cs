using FinalBankExampleCore.Repositories.BankAccountRepository;
using FinalBankExampleCore.Repositories.UserRepository;

namespace FinalBankExampleCore.UnitOfWork
{
    public interface ISqlUnitOfWork : IDisposable
    {
        public void Commit();
    }
}
