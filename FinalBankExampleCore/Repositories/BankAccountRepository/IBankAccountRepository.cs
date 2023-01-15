using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Repositories.GenericRepository;

namespace FinalBankExampleCore.Repositories.BankAccountRepository
{
    public interface IBankAccountRepository:IGenericRepository<BankAccount>
    {
        BankAccount GetAccountByAccountNumber(int accountNumber);

    }
}
