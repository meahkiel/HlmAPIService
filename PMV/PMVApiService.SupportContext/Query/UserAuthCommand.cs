
using PMV.PMVApiService.SupportContext.Connections;
using PMV.PMVApiService.SupportContext.DTO;

namespace PMV.PMVApiService.SupportContext.Query;

public class UserAuthCommand : BaseQuery<AuthResult?> {

    public string EmployeeCode { get; set; } = null!;

    public UserAuthCommand(SupportDataConnection connection) 
        : base(connection)
    {
        
    }

    public override async Task<AuthResult?> ExecuteAsync() {

        string sql = "SELECT EmpCode,EmpPasswd FROM EmployeeLogin WHERE EmpCode = @empCode";
    
        var result = await this.GetQuerySingle(sql,new {empCode = EmployeeCode});

        return result;
    }
}