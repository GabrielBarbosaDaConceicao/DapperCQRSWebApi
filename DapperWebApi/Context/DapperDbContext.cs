using DapperWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DapperWebApi.Context
{
    public class DapperDbContext : DbContext
    {
        public DapperDbContext(DbContextOptions<DapperDbContext> options) : base(options)
        {
        }

        public DbSet<User>? Users { get; set; }
    }
}
