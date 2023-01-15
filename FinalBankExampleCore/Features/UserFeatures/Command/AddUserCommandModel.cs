using MediatR;

namespace FinalBankExampleCore.Features.UserFeatures.Command
{
    public class AddUserCommandModel : IRequest<bool>
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiesDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
