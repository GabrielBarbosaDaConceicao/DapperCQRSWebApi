using Dapper;
using DapperWebApi.Entities;
using DapperWebApi.Interfaces;
using Microsoft.Data.SqlClient;

namespace DapperWebApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SqlConnectionRepository _connectionRepository;

        public UserRepository(SqlConnectionRepository connectionRepository)
        {
            _connectionRepository = connectionRepository;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            using (var connection = new SqlConnection(_connectionRepository.ConnectionString()))
            {
                var sql = "SELECT * FROM Users";
                return await connection.QueryAsync<User>(sql);
            }
        }

        public async Task<User> GetUserById(int id)
        {
            using (var connection = new SqlConnection(_connectionRepository.ConnectionString()))
            {
                var sql = "SELECT * FROM Users WHERE Id = @id";
                return  await connection.QueryFirstOrDefaultAsync<User>(sql, new { Id = id });
            }
        }

        public async Task<IEnumerable<User>> AddUser(User user)
        {
            using (var connection = new SqlConnection(_connectionRepository.ConnectionString()))
            {
                var sql = "INSERT INTO Users(Name, Email) VALUES(@Name, @Email)";
                await connection.ExecuteAsync(sql, new { Name = user.Name, Email =user.Email });
                return await GetUsers();
            }
           
        }
    }
}
