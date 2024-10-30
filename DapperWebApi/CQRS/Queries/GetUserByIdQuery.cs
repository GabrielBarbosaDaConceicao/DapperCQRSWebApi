using DapperWebApi.Entities;
using MediatR;

namespace DapperWebApi.CQRS.Queries
{
    public class GetUserByIdQuery : IRequest<User>
    {
        public int Id { get; set; }

        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
