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
    MadLibVariable newMadLib = new MadLibVariable();
    newMadLib.Person1 = person1;
    newMadLib.Person2 = person2;
    newMadLib.Animal = animal;
    newMadLib.Exclamation = exclamation;
    newMadLib.Verb = verb;
    newMadLib.Noun = noun;
    return View(newMadLib);
    }

    [Route("/story2")]
    public ActionResult Story2(string person1, string person2, string animal, string exclamation, string verb, string noun)
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