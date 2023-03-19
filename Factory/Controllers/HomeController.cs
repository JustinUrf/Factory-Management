using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Linq;
using System.Collections.Generic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    private readonly FactoryContext _db;

    public HomeController(FactoryContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      License[] theseLicenses = _db.Licenses.ToArray();
      Engineer[] theseEngineers = _db.Engineers.ToArray();
      Dictionary<string,object[]> model = new Dictionary<string, object[]>();
      model.Add("licenses", theseLicenses);
      model.Add("engineers", theseEngineers);
      return View(model);
    }
  }
}