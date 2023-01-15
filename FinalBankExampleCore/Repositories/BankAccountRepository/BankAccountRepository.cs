using FinalBankExampleCore.DataContext;
using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Repositories.GenericRepository;

namespace FinalBankExampleCore.Repositories.BankAccountRepository
{

    public class BankAccountRepository : GenericRepository<BankAccount>, IBankAccountRepository
    {
        private readonly SQLDataContext sQLDataContext;
        public BankAccountRepository(SQLDataContext dataContext) : base(dataContext)
        {
            sQLDataContext = dataContext;
        }

        public BankAccount GetAccountByAccountNumber(int accountNumber)
        {
            return sQLDataContext.BankAccounts.Where(x => x.AccountNumber == accountNumber).FirstOrDefault();
        }

    }
}
