# GestioneSagre Image

[![NuGet](https://img.shields.io/nuget/v/GestioneSagre.Image.svg?logo=nuget&style=for-the-badge)](https://www.nuget.org/packages/GestioneSagre.Image)
[![Nuget](https://img.shields.io/nuget/dt/GestioneSagre.Image.svg?logo=nuget&style=for-the-badge)](https://www.nuget.org/packages/GestioneSagre.Image)
[![MIT](https://img.shields.io/github/license/GestioneSagre/GestioneSagre.Image?logo=github&style=for-the-badge)](https://github.com/GestioneSagre/GestioneSagre.Image/blob/master/LICENSE)
![Github](https://img.shields.io/github/last-commit/GestioneSagre/GestioneSagre.Image?logo=github&style=for-the-badge)
[![Github](https://img.shields.io/github/contributors/GestioneSagre/GestioneSagre.Image?logo=github&style=for-the-badge)](https://github.com/GestioneSagre/GestioneSagre.Image/graphs/contributors)


### Installation

The library is available on [NuGet](https://www.nuget.org/packages/GestioneSagre.Image).


## Usage/Examples

An example of how to invoke the SaveImageAsync method

**NOTE:** In this example the model values are declared directly in the InputModel class, but this is not required

*Model example*

```
namespace MyProject;

public class InputModel
{
  public string imageName { get; set; } = "7c9e6679-7425-40de-944b-e07fc1f90ae7";
  public string imageExtension { get; set; } = "jpg";
  public string imagePath { get; set; } = "images";
  public IFormFile formFile { get; set; }
}
```

*Class example*
```
namespace MyProject;

public class MyClass
{
  private readonly IImagePersister imagePersister;

  public MyClass(IImagePersister imagePersister)
  {
    this.imagePersister = imagePersister;
  }

  public async Task UploadImageAsync(InputModel model)
  {
    //pathImage gets the path to the image (e.g. /images/foto-1.jpg)
    string pathImage = await imagePersister.SaveImageAsync(imageName, imageExtension, imagePath, formFile);

    await dbContext.SaveChangesAsync();
  }
}
```
