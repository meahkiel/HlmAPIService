using System.Data.SqlClient;

namespace PMV.PMVApiService.SupportContext.Connections
{
    public class SupportDataConnection : IDisposable
    {

        private readonly SqlConnection _sqlConnection;


        public SupportDataConnection(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Open() {
            _sqlConnection.Open();
        }

        public void Close() {
            _sqlConnection.Close();
        }

        public SqlConnection GetConnection() {
            return _sqlConnection;
        }

       

        public void Dispose()
        {
            _sqlConnection.Dispose();
        }
    }
}