using Microsoft.AspNetCore.Http;

namespace GestioneSagre.Image.Services.Interfaces;

public interface IImagePersister
{
    Task<string> SaveImageAsync(string ImageName, string ImageExtension, string ImagePath, IFormFile formFile);
}