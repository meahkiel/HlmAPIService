namespace PMV.Application.DTO.Login;

public record AuthResponse(string EmployeeCode, string EmployeeName, string LVStation, string Token);