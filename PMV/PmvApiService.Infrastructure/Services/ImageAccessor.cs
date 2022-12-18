using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using PMV.Application.Core;
using PMV.Application.Interfaces;
using PMV.Infrastructure.Core;

namespace PMV.Infrastructure.Services;

public class ImageAccessor : IImageAccessor
{

    private string _basePath;
    private string _urlBasePath;

    public ImageAccessor(IOptions<ResourceSetting> options)
    {
        _basePath = options.Value.ImageBasePath;
        _urlBasePath = options.Value.UrlBasePath;
    }

    private string CreateFilePath(IFormFile formFile, FileInfo fileInfo, string lvStation, string assetCode, string classification, out string formatFileName)
    {

        var folderPerDate = $"Galleries_{DateTime.Today.ToShortDateString()}";
        string destinationPath = _basePath + folderPerDate;

        formatFileName = $"{lvStation}_{assetCode}_{classification}_{Guid.NewGuid().ToString()}{fileInfo.Extension}";

        if (!Directory.Exists(destinationPath))
        {
            var info = Directory.CreateDirectory(_basePath + folderPerDate);
        }

        return Path.Combine(destinationPath, formatFileName);
    }

    private string CreateFilePath(string extension, string lvStation, string assetCode, string classification, out string formatFileName)
    {

        var folderPerDate = $"Galleries_{DateTime.Today.ToShortDateString()}";
        string destinationPath = _basePath + folderPerDate;

        formatFileName = $"{lvStation}_{assetCode}_{classification}_{Guid.NewGuid().ToString()}{extension}";

        if (!Directory.Exists(destinationPath))
        {
            var info = Directory.CreateDirectory(_basePath + folderPerDate);
        }

        return Path.Combine(destinationPath, formatFileName);
    }



    public async Task<PhotoResult> SavePhoto(IFormFile file, string lvStation, string assetCode, string classification)
    {

        FileInfo fileInfo = new FileInfo(file.FileName);
        string filePath = CreateFilePath(file, fileInfo, lvStation, assetCode, classification, out string formatFileName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }

        return new PhotoResult
        {
            Name = file.FileName,
            PhysicalPath = filePath,
            FileName = formatFileName,
            Url = _urlBasePath,
            Type = fileInfo.Extension
        };
    }

    public PhotoResult SaveBinaryPhoto(byte[]? fileData, string fileName, string lvStation, string assetCode, string classification)
    {
        string filePath = CreateFilePath(".png", lvStation, assetCode, classification, out string formatFileName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            fileStream.Write(fileData!, 0, fileData!.Length);
        }

        return new PhotoResult
        {
            Name = fileName,
            PhysicalPath = filePath,
            FileName = formatFileName,
            Url = _urlBasePath,
            Type = ".png"
        };
    }

    public PhotoResult UploadedFromSharepoint(string fileName, string classification)
    {
        return new PhotoResult
        {
            Name = classification,
            FileName = fileName,
            Classification = classification,
            Type = "sp",
            Url = _urlBasePath,
            PhysicalPath = _basePath
        };
    }
}