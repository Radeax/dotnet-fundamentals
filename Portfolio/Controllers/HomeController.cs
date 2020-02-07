using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet]
    [Route("")]
    public string Index()
    {
      return "This is my index!";
    }
  }
}