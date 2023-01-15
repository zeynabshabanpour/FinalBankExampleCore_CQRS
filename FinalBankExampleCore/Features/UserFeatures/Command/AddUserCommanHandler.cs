using FinalBankExampleCore.Repositories.UserRepository;
using MediatR;

namespace FinalBankExampleCore.Features.UserFeatures.Command
{
    public class AddUserCommanHandler : IRequestHandler<AddUserCommandModel, bool>
    {
        private readonly IUserRepository _userRepository;
        public AddUserCommanHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> Handle(AddUserCommandModel request, CancellationToken cancellationToken)
        {
            _userRepository.SaveEntity(new Entities.User());
            return Task.FromResult(true);
        }
    }
}
