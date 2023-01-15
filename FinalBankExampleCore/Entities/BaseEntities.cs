using System.ComponentModel.DataAnnotations;

namespace FinalBankExampleCore.Entities
{
    public class BaseEntities
    {
        [Key]
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiesDate { get; set; }
    }
}
