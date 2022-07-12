using Microsoft.AspNetCore.Http;

namespace GestioneSagre.Image.Services.Interfaces;

public interface IImagePersister
{
    Task<string> SaveLogoAsync(int festaId, IFormFile formFile);
}