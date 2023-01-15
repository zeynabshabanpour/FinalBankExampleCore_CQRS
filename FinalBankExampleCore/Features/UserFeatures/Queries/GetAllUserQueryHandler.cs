using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Repositories.UserRepository;
using MediatR;

namespace FinalBankExampleCore.Features.UserFeatures.Queries
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryModel, List<User>>
    {
        private readonly IUserRepository userRepository;
        public GetAllUserQueryHandler( IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public Task<List<User>> Handle(GetAllUserQueryModel request, CancellationToken cancellationToken)
        {
            var result = userRepository.GetAllEntity();
            return Task.FromResult(result);
        }
    }
}
