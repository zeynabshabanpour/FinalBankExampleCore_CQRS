using MediatR;

namespace FinalBankExampleCore.Features.AccountFeatures.Command.TransferThreeAccount
{
    public class MoneyTransferCommandModel : IRequest<bool>
    {
        public int SrcAccount { get; set; }
        public int DesAccountOne { get; set; }
        public int DesAccountTwo { get; set; }
        public int DesAccountThree { get; set; }
        public int Amount { get; set; }

    }
}
