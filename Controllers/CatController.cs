using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace Simple.Test.Controllers;

[ApiController]
[Route("[controller]")]
public class CatController : ControllerBase
{
  private static readonly string[] CatNames = new[]
  {
    "Oliver", "Leo", "Milo", "Charlie", "Simba", "Max", "Jack", "Loki", "Tiger", "Ollie", "Olivia", "Buddy"
  };

  private readonly ILogger<CatController> _logger;

  public CatController(ILogger<CatController> logger)
  {
    _logger = logger;
  }

  public class CatInformation 
  {
    public CatInformation(string name, string photo) {
      this.Name = name;
      this.Photo = photo;
    }

    public string Name { get; private set; }
    public string Photo { get; private set; }
  }

  // Controller should be cleaned up 
  [HttpGet]
  [Route("{limit}")]
  public IEnumerable<CatInformation> Get(int limit)
  {
    var currentDirectory = Directory.GetCurrentDirectory();
    DirectoryInfo catPhotosDirectory = new DirectoryInfo($"{currentDirectory}/ClientApp/public/photos");
    FileInfo[] catPhotos = catPhotosDirectory.GetFiles("*.jpg");

    return Enumerable.Range(1, limit).Select(index => new CatInformation(CatNames[Random.Shared.Next(CatNames.Length)], catPhotos[Random.Shared.Next(catPhotos.Length)].Name)).ToArray();
  }
}
