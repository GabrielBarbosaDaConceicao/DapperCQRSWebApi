using DapperWebApi.Entities;
using MediatR;

namespace DapperWebApi.CQRS.Commands
{
    public class CreateUserCommand : IRequest<User>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
