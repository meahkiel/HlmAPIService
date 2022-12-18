using Microsoft.AspNetCore.Http;

namespace PMV.Application.Core;

public class FormFileRequest
{
    public FormFileRequest(IFormFile formFile, string classification)
    {
        FormFile = formFile;
        Classification = classification;
    }
    public IFormFile FormFile { get; private set; } = null!;
    public string Classification { get; private set; } = "";
}