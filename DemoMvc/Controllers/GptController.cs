using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers;
using DemoMvc.Models;
public class GptController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Solve(Gpt gpt)
    {
        if (gpt.A == 0)
        {
            ViewBag.A = "PT vo nghiem";
            return View("Index", gpt);
        }else{

        gpt.X = -gpt.B / gpt.A;
        ViewBag.B= "X= " +gpt.X;
        return View("Index", gpt);
        }
    }
}