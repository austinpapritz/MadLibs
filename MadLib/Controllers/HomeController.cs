using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/madlib")]
    public ActionResult MadLibResults(string noun) {
      MadLibVariables newMadLib = new MadLibVariables(noun);
      return View(newMadLib);
    }

    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }