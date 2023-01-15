using FinalBankExampleCore.Entities;
using MediatR;

namespace FinalBankExampleCore.Features.UserFeatures.Queries
{
    public class GetAllUserQueryModel : IRequest<List<User>>
    {
    }
}
