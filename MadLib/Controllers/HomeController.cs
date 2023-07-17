using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/madlib")]
    public ActionResult MadLibResults(string[] args) {
      MadLibVariables newMadLib = new MadLibVariables(args);
      return View(newMadLib);
    }

    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }