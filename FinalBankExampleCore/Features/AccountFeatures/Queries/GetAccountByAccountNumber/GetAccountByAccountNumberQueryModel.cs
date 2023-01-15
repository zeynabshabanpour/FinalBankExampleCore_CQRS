using FinalBankExampleCore.Entities;
using MediatR;

namespace FinalBankExampleCore.Features.AccountFeatures.Queries.GetAccountByAccountNumber
{
    public class GetAccountByAccountNumberQueryModel : IRequest<BankAccount>
    {
        public int AccountNumber { get; set; }
    }
}
