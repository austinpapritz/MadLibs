using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {


    [Route("/madlib")]
    public ActionResult MadLibResults(MadLibVariables args) {
      return View(args);
    }

    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }