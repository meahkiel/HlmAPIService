using PMV.Application.DTO.Login;

namespace PMV.Application.Interfaces;

public interface IAuthService
{
    Task<bool> Login(AuthRequest request);

}