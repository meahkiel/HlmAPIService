namespace PMV.PmvApiService.Core.User
{
    public interface IUserRepository
    {
        Task<PMVUser> GetUserProfile(string employeeCode);
    }
}