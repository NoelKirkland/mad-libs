using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/story")]
    public ActionResult Story(string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
    MadLibVariable newMadLib = new MadLibVariable();
    newMadLib.Person1 = person1;
    newMadLib.Person2 = person2;
    newMadLib.Animal = animal;
    newMadLib.Exclamation = exclamation;
    newMadLib.Verb = verb;
    newMadLib.Noun = noun;
    return View(newMadLib);
}
  }
}