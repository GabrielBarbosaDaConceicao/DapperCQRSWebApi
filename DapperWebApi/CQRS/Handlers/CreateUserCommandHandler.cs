using DapperWebApi.Entities;
using DapperWebApi.CQRS.Commands;
using MediatR;
using DapperWebApi.Interfaces;

namespace DapperWebApi.CQRS.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, User>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User()
            {
                Name = request.Name,
                Email = request.Email,
            };

             await _userRepository.AddUser(user);

            return user;
        }
    }
}
