using Dapper;
using PMV.PMVApiService.SupportContext.Connections;

namespace PMV.PMVApiService.SupportContext.Query;

public abstract class BaseQuery<TResult>
{

    protected readonly SupportDataConnection _connection;

    protected BaseQuery(SupportDataConnection connection)
    {
        _connection = connection;
    }

    protected async Task<TResult> GetQueryAllDynamicParam<TRes>(string query, DynamicParameters parameter)
    {
        using (var con = _connection.GetConnection())
        {
            con.Open();
            var result = await con.QueryAsync<TRes>(query, parameter, commandType: System.Data.CommandType.StoredProcedure);
            con.Close();
            return (TResult)result;
        }
    }

    protected async Task<TResult> GetQueryAll<TRes>(string query, object parameter = null)
    {
        using (var con = _connection.GetConnection())
        {
            con.Open();
            var result = await con.QueryAsync<TRes>(query, parameter);
            con.Close();
            return (TResult)result;

        }
    }

     protected async Task<TResult> GetQuerySingle(string query, object parameter)
    {

        using (var con = _connection.GetConnection())
        {
            con.Open();
            var result = await con.QuerySingleAsync<TResult>(query, parameter);
            con.Close();
            
            return result;
        }
    }


    public abstract Task<TResult> ExecuteAsync();

    
}