using PMV.PmvApiService.Application.DTO.Login;

namespace PMV.PmvApiService.Application.Interfaces.Authentications
{
    public interface IAuthService
    {
        Task<bool> Login(AuthRequest request);

    }
}