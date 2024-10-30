using DapperWebApi.Entities;
using MediatR;

namespace DapperWebApi.CQRS.Queries
{
    public class GetUsersQuery : IRequest<IEnumerable<User>>
    {
    }
}
