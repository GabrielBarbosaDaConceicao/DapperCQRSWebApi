using DapperWebApi.Entities;
using DapperWebApi.Interfaces;
using DapperWebApi.Services.Interfaces;

namespace DapperWebApi.Services
{
    public class UserService : IUserService
    {
        private readonly DapperWebApi.Interfaces.IUserRepository _userRepository;

        public UserService(DapperWebApi.Interfaces.IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            var users = await _userRepository.GetUsers();
            return users;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetUserById(id);
            return user;
        }

        public async Task<IEnumerable<User>> AddUserAsync(User user)
        {
            var result = await _userRepository.AddUser(user);
           
            return result;
        }
    }
}
