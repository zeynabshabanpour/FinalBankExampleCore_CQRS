namespace FinalBankExampleCore.Entities
{
    public class User : BaseEntities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        #region relation
        public virtual BankAccount BankAccount { get; set; }
        #endregion
    }
}
