using DapperWebApi.CQRS.Queries;
using DapperWebApi.Entities;
using DapperWebApi.Interfaces;
using MediatR;

namespace DapperWebApi.CQRS.Handlers
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
           return await _userRepository.GetUserById(request.Id);
        }
    }
}
