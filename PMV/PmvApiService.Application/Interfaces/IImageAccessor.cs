using Microsoft.AspNetCore.Http;
using PMV.PmvApiService.Application.Core;

namespace PMV.PmvApiService.Application.Interfaces
{

    public interface IImageAccessor
    {

        PhotoResult UploadedFromSharepoint(string fileName,string classification);

        PhotoResult SaveBinaryPhoto(byte[]? fileData,string fileName,string lvStation,string assetCode,string classification);
        Task<PhotoResult> SavePhoto(IFormFile file,string lvStation,string assetCode,string classification);
    }
}