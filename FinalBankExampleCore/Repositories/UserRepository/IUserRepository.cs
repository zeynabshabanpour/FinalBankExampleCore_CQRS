using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Features.UserFeatures.Command;
using FinalBankExampleCore.Repositories.GenericRepository;

namespace FinalBankExampleCore.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
            
    }
}
