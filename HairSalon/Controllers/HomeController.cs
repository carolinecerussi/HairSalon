
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Hair Salon";
      return View();
    }
  }
}