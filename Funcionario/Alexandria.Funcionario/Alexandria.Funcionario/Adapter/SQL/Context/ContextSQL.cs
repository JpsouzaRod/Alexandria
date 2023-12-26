using Microsoft.Data.SqlClient;
using System.Data;

namespace Alexandria.Funcionario.Adapter.SQL.Context
{
    public class ContextSQL
    {
        public ContextSQL(IConfiguration provider) 
        {
            ConnectionString = provider.GetConnectionString("SqlServer");
        }
        public string ConnectionString { get; set; }

        public IDbConnection CreateConnection() => new SqlConnection(ConnectionString);
    }
}
