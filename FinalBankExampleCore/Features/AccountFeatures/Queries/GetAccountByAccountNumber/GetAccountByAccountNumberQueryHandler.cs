using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Repositories.BankAccountRepository;
using MediatR;

namespace FinalBankExampleCore.Features.AccountFeatures.Queries.GetAccountByAccountNumber
{
    public class GetAccountByAccountNumberQueryHandler : IRequestHandler<GetAccountByAccountNumberQueryModel, BankAccount>
    {
        private readonly IBankAccountRepository bankAccountRepository;
        public GetAccountByAccountNumberQueryHandler(IBankAccountRepository bankAccountRepository)
        {
            this.bankAccountRepository = bankAccountRepository;
        }
        public Task<BankAccount> Handle(GetAccountByAccountNumberQueryModel request, CancellationToken cancellationToken)
        {
            var result = bankAccountRepository.GetAccountByAccountNumber(request.AccountNumber);
            return Task.FromResult(result);
        }
    }
}
