using System.ComponentModel.DataAnnotations.Schema;

namespace FinalBankExampleCore.Entities
{
    public class BankAccount : BaseEntities
    {
        public int Balance { get; set; }
        public int AccountNumber { get; set; }
        public int UserID { get; set; }
        public bool IsBlock { get; set; }
        public DateTime LastTransactionDate { get; set; }

        #region relation

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
        #endregion
    }
}
