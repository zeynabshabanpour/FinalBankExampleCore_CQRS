using FinalBankExampleCore.DataContext;
using FinalBankExampleCore.Entities;
using FinalBankExampleCore.Repositories.GenericRepository;

namespace FinalBankExampleCore.Repositories.UserRepository
{
    public class UserRepository :  GenericRepository<User>, IUserRepository
    {
        private readonly SQLDataContext context;
        public UserRepository(SQLDataContext dataContext) : base(dataContext)
        {
            this.context = dataContext;
        }

    }
}
