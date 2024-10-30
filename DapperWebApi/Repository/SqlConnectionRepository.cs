namespace DapperWebApi.Repository
{
    public class SqlConnectionRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public SqlConnectionRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public string ConnectionString()
        {
            return connectionString;
        }
    }
}
