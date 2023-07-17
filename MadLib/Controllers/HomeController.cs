using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/alienmadlib")]
    public ActionResult AlienMadLibResults(AlienMadLibVariables args) {
      return View(args);
    }

    [Route("/alienform")]
    public ActionResult AlienForm() {
      return View();
    }

    [Route("/erikmadlib")]
    public ActionResult ErikMadLibResults() {
      return View();
    }

    [Route("/erikform")]
    public ActionResult ErikForm() {
       ErikMadLibVariables newErik = new ErikMadLibVariables("NotErik");
        return View(newErik);
    }
    


  }