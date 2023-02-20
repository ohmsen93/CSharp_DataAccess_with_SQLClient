using Microsoft.Data.SqlClient;

namespace CSharp_DataAccess_with_SQLClient.Repositories;

public class ConnectionStringHelper
{
    public static string GetConnectionString()
    {
        SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
        connectionStringBuilder.DataSource = "DESKTOP-1J1N5RM\\SQLEXPRESS";
        connectionStringBuilder.InitialCatalog = "Chinook";
        connectionStringBuilder.IntegratedSecurity = true;
        connectionStringBuilder.TrustServerCertificate = true;
        return connectionStringBuilder.ConnectionString;
    }
}