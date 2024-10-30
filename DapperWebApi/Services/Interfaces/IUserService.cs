using DapperWebApi.Entities;

namespace DapperWebApi.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<IEnumerable<User>> AddUserAsync(User user);
    }
}
