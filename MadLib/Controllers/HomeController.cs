using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }