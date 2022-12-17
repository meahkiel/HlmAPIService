namespace PMV.PmvApiService.Application.Core
{
    public class PhotoResult
    {
        public string Url { get; set; } = "";
        public string PhysicalPath { get; set; } = "";
        public string FileName { get; set; } = "";
        public string Name { get; set; } = "";
        public string Type { get; set; } = "";

        public string Classification { get; set; } = "";
    }
}