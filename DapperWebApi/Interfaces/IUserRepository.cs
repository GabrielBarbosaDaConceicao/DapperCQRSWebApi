using DapperWebApi.Entities;

namespace DapperWebApi.Interfaces
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task<IEnumerable<User>> AddUser(User user);
    }
}
