using PMV.PmvApiService.Core.BaseEntity;


namespace PMV.PmvApiService.Core.User
{
    public class PMVUser : AggregateRoot
    {
        public string EmployeeCode { get; set; } = "";
        public string? EmailAddress { get; set; } = "";
        public string FullName { get; set; } = "";
        public string? Department { get; set; } = "";
        public string? Section { get; set; } = "";

    }
}