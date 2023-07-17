using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/madlib")]
    public ActionResult MadLibResults() {
      return View();
    }

    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }