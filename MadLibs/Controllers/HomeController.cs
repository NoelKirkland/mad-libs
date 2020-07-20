using MadLib.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLib.Controllers
{
  public class HomeController : Controller
  {

    // [Route("/")]
    // public ActionResult Letter() 
    // { 
    //   LetterVariable myLetterVariable = new LetterVariable();
    //   myLetterVariable.Recipient = "Lina";
    //   myLetterVariable.Sender = "Jasmine";
    //   return View(myLetterVariable); 
    // }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
    MadLibVariable newMadLib = new MadLibVariable();
    newMadLib.Recipient = recipient;
    newMadLib.Sender = sender;
    return View(newMadLib);
}
  }
}