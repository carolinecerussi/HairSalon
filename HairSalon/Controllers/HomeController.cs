
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.PageTitle = "HairSalon";
      return View();
    }
  }
}