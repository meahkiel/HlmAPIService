using PMV.SupportContext.Connections;
using PMV.SupportContext.DTO;

namespace PMV.SupportContext.Query;

public class UserAuthCommand : BaseQuery<AuthResult?>
{

    public string EmployeeCode { get; set; } = null!;

    public UserAuthCommand(SupportDataConnection connection)
        : base(connection)
    {

    }

    public override async Task<AuthResult?> ExecuteAsync()
    {

        string sql = "SELECT EmpCode,EmpPasswd FROM EmployeeLogin WHERE EmpCode = @empCode";

        var result = await GetQuerySingle(sql, new { empCode = EmployeeCode });

        return result;
    }
}