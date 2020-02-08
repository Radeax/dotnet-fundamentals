using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }
  }
}