using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        //[Route("/")]
        //public ActionResult FinalMadLib()
        //{

        //    MadLibVariable test = new MadLibVariable();     
        //    return View(test);
        //}

        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }

        [Route("/mad_action")]
        public ActionResult MadAction()
        {
            MadLibVariable newMadLib = new MadLibVariable();
            newMadLib.SetName(Request.Query["name"]);
            newMadLib.SetPlace(Request.Query["place"]);
            newMadLib.SetVerb(Request.Query["verb"]);
            return View("FinalMadLib", newMadLib);
        }
    }
}
