namespace PMV.PmvApiService.Application.DTO.Login
{
    public class AuthRequest
    {
        public string EmployeeCode { get; set; } = null!;
        
        public string Password { get; set; } = null!;
    }
}