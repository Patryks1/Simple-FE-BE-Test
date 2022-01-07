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
  
}
