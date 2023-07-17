using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/madlib")]
    public ActionResult MadLibResults() {
      MadLibVariables newMadLib = new MadLibVariables();
      newMadLib.Noun = "fireman";
      newMadLib.Verb = "burning";
      newMadLib.Place = "house";
      return View(newMadLib);
    }

    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }