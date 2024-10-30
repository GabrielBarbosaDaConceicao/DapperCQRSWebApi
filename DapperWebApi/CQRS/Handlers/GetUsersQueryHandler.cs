using DapperWebApi.CQRS.Queries;
using DapperWebApi.Entities;
using DapperWebApi.Interfaces;
using MediatR;

namespace DapperWebApi.CQRS.Handlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<User>>
    {
        private readonly IUserRepository _userRepository;

        public GetUsersQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUsers();
        }
    }
}
