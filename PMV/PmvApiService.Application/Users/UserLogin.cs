using MediatR;
using PMV.PmvApiService.Application.Core;
using PMV.PmvApiService.Application.Interfaces.Authentications;
using PMV.PmvApiService.Application.Interfaces.Repositories;
using PMV.PmvApiService.Application.DTO.Login;

namespace PMV.PmvApiService.Application.Users;

public class UserLogin
{
    public record Query(AuthRequest Request) : IRequest<Result<AuthResponse>>;

    public class QueryHandler : IRequestHandler<Query, Result<AuthResponse>>
    {
        private readonly IAuthService _service;
        private readonly IUnitWork _unitWork;

        public QueryHandler(IAuthService service,IUnitWork unitWork)
        {
            _service = service;
            _unitWork = unitWork;
        }


        public async Task<Result<AuthResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            

            var isUserLogin = await _service.Login(request.Request);
                
            if(!isUserLogin) 
                throw new Exception("User or Password is incorrect");
            
            var user = await _unitWork.Users.GetUserProfile(request.Request.EmployeeCode);

            AuthResponse response = new AuthResponse(user.EmployeeCode,user.FullName,user.Section ?? "","123456");

            return Result<AuthResponse>.Success(response);

            
        }
    }
}