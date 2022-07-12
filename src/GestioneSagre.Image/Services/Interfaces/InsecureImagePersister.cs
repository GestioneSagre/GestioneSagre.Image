using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace GestioneSagre.Image.Services.Interfaces;

public class InsecureImagePersister : IImagePersister
{
    private readonly IHostingEnvironment env;

    public InsecureImagePersister(IHostingEnvironment env)
    {
        this.env = env;
    }

    public async Task<string> SaveImageAsync(string ImageName, string ImageExtension, string ImagePath, IFormFile formFile)
    {
        //var path = $"/images/festa-{festaId}.jpg";
        var path = $"/{ImagePath}/{ImageName}.{ImageExtension}";

        //var physicalPath = Path.Combine(env.WebRootPath, "images", $"festa-{festaId}.jpg");
        var physicalPath = Path.Combine(env.WebRootPath, ImagePath, $"{ImageName}.{ImageExtension}");

        using var fileStream = File.OpenWrite(physicalPath);

        await formFile.CopyToAsync(fileStream);

        return path;
    }
}