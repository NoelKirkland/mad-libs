using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult FormGate() { return View(); }

    [Route("/form1")]
    public ActionResult Form1() { return View(); }

    [Route("/form2")]
    public ActionResult Form2() { return View(); }

    [Route("/story1")]
    public ActionResult Story1(string person1, string person2, string animal, string exclamation, string verb, string noun)
    {
    MadLibVariable1 newMadLib = new MadLibVariable1();
    newMadLib.Person1 = person1;
    newMadLib.Person2 = person2;
    newMadLib.Animal = animal;
    newMadLib.Exclamation = exclamation;
    newMadLib.Verb = verb;
    newMadLib.Noun = noun;
    return View(newMadLib);
    }

    [Route("/story2")]
    public ActionResult Story2(string adjective1, string adjective2, string bird, string room, string verb1, string verb2, string relative, string noun, string drink, string verbIng1, string bodyPart, string nounPlural, string verbIng2, string noun2)
    {
    MadLibVariable2 newMadLib = new MadLibVariable2();
    newMadLib.Adjective1= adjective1;
    newMadLib.Adjective2 = adjective2;
    newMadLib.Bird = bird;
    newMadLib.Room = room;
    newMadLib.Verb1 = verb1;
    newMadLib.Verb2 = verb2;
    newMadLib.Relative = relative;
    newMadLib.Noun = noun;
    newMadLib.Drink = drink;
    newMadLib.VerbIng1 = verbIng1;
    newMadLib.BodyPart = bodyPart;
    newMadLib.NounPlural = nounPlural;
    newMadLib.VerbIng2 = verbIng2;
    newMadLib.Noun2 = noun2;
    return View(newMadLib);
    }
  }
}