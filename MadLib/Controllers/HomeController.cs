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
    public ActionResult ErikMadLibResults(string dummyName) {
     ErikMadLibVariables newErik = new ErikMadLibVariables( dummyName );
      return View(newErik);
    }

    [Route("/erikform")]
    public ActionResult ErikForm() {
        return View();
    }
    


  }