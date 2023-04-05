using System.Data.SqlClient;

namespace DatabaseConnectivity.DbConnection;
public class Context
{
    private string connectionString = "Data Source=CAMOUFLY;Database=db_hr_dts;Integrated Security=True;Connect Timeout=30;";
    private SqlConnection connection;

    public SqlConnection GetConnection()
    {
        try {
            connection = new SqlConnection(connectionString);
        } catch {
            return null;
        }

        return connection;
    }
}
