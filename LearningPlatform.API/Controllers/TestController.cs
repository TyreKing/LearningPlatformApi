using Microsoft.AspNetCore.Mvc;

namespace LearningPlatform.API.Controllers;

[Controller]
[Route("[controller]")]
public class TestController : Controller
{
    [HttpGet]
    public IActionResult Test()
    {
        return Ok();
    }
}