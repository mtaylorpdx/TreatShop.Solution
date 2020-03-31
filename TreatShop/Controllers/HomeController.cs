using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TreatShop.Models;

namespace TreatShop.Controllers
{
  public class HomeController : Controller
  {

    private readonly TreatShopContext _db;

    public HomeController(TreatShopContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Flavors = _db.Flavors.ToList();
      return View(_db.Treats.ToList());
    }
  }
}