namespace FinalBankExampleCore.Dtos
{
    public class TransferAccountDto
    {
        public int SrcAccount { get; set; }
        public int DesAccountOne { get; set; }
        public int DesAccountTwo { get; set; }
        public int DesAccountThree { get; set; }
        public int Amount { get; set; }
    }
}
