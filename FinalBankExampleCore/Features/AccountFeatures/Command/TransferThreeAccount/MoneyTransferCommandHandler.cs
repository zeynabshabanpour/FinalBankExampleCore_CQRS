using FinalBankExampleCore.DataContext;
using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Repositories.BankAccountRepository;
using FinalBankExampleCore.UnitOfWork;
using MediatR;

namespace FinalBankExampleCore.Features.AccountFeatures.Command.TransferThreeAccount
{
    public class MoneyTransferCommandHandler : IRequestHandler<MoneyTransferCommandModel, bool>
    {
        private readonly ISqlUnitOfWork sqlUnit;
        private readonly IBankAccountRepository bankAccountRepository;
        private readonly SQLDataContext sQLContext;
        public MoneyTransferCommandHandler(ISqlUnitOfWork sqlUnit, SQLDataContext sQLContext, IBankAccountRepository bankAccountRepository)
        {
            this.sqlUnit = sqlUnit;
            this.sQLContext = sQLContext;
            this.bankAccountRepository = bankAccountRepository;
        }
        public Task<bool> Handle(MoneyTransferCommandModel request, CancellationToken cancellationToken)
        {
            bool IsNull(BankAccount bankAccount)
            {
                if (bankAccount == null)
                    return true;
                return false;
            }
            bool IsBlock(BankAccount bankAccount)
            {
                if (bankAccount.IsBlock)
                    return true;
                return false;
            }
          
            var srcAccount = bankAccountRepository.GetAccountByAccountNumber(request.SrcAccount);
            var desAccountTwo = bankAccountRepository.GetAccountByAccountNumber(request.DesAccountTwo);
            var desAccountOne = bankAccountRepository.GetAccountByAccountNumber(request.DesAccountOne);
            var desAccountThree = bankAccountRepository.GetAccountByAccountNumber(request.DesAccountThree);

            if (IsNull(srcAccount) || IsNull(desAccountThree) || IsNull(desAccountTwo) || IsNull(desAccountOne))
                return Task.FromResult(false);
            if (IsBlock(srcAccount) || IsBlock(desAccountThree) || IsBlock(desAccountTwo) || IsBlock(desAccountOne))
                return Task.FromResult(false);

            int dividedAmount = request.Amount / 3;

            var transaction = sQLContext.Database.BeginTransaction();
            try
            {
                if (srcAccount.Balance >= request.Amount)
                {
                    srcAccount.Balance -= request.Amount;
                    desAccountOne.Balance += dividedAmount;
                    desAccountTwo.Balance += dividedAmount;
                    desAccountThree.Balance += dividedAmount;

                    bankAccountRepository.UpdateEntity(srcAccount);
                    bankAccountRepository.UpdateEntity(desAccountOne);
                    bankAccountRepository.UpdateEntity(desAccountTwo);
                    bankAccountRepository.UpdateEntity(desAccountThree);
                    sqlUnit.Commit();

                    transaction.Commit();
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                    throw new ApplicationException("the amount is more than balance");
                }
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return Task.FromResult(false);
            }

        }
    }
}
