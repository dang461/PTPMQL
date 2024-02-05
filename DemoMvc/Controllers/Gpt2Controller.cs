using Microsoft.AspNetCore.Mvc;
namespace DemoMvc.Controllers;
using DemoMvc.Models;
public class Gpt2Controller : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Solve(Gpt2 gpt)
    {
        if (gpt.A == 0)
        {
            ViewBag.D = "A phai khac 0.";
            return View("Index", gpt);
        }

        gpt.Delta = gpt.B * gpt.B - 4 * gpt.A * gpt.C;
        ViewBag.A= "delta= " +gpt.Delta;
        if (gpt.Delta < 0)
        {
            ViewBag.B= "Phuong trinh khong vo nghiem.";
        }
        else if (gpt.Delta == 0)
        {
            gpt.X1 = -gpt.B / (2 * gpt.A);
            ViewBag.C = "Phuong trinh co nghiem kep: X1=X2="+gpt.X1;
        }
        else
        {
            gpt.X1 = (-gpt.B + Math.Sqrt(gpt.Delta)) / (2 * gpt.A);
            gpt.X2 = (-gpt.B - Math.Sqrt(gpt.Delta)) / (2 * gpt.A);
            ViewBag.D ="Phuong trinh co 2 nghiem: " + " X1= " + gpt.X1 + " ; "+ "X2 = " + gpt.X2;
        }


        return View("Index", gpt);
    }
}