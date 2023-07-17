using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
  {
    [Route("/madlib")]
    public ActionResult MadLibResults(string femaleName, string planetName, string naturalEventPlural, string pastTenseVerb, string alienNoun, string alienAdjective, string triumphAdjective, string dreamVerb, string cosmosNoun, string pluralNoun) {
      MadLibVariables newMadLib = new MadLibVariables(femaleName, planetName, naturalEventPlural, pastTenseVerb, alienNoun, alienAdjective, triumphAdjective, dreamVerb, cosmosNoun, pluralNoun);
      return View(newMadLib);
    }

    [Route("/")]
    public ActionResult Form() {
      return View();
    }
  }