using System;
using System.Reflection.Metadata;
using System.Reflection.Emit;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class TinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(Calculate calculate)
        {
                calculate.Cal1 = calculate.A - calculate.B;
                ViewBag.A = "Hieu: " + calculate.Cal1;
                calculate.Cal2 = calculate.A * calculate.B;
                ViewBag.B = "Tich: " + calculate.Cal2;
            if(calculate.B != 0){
                calculate.Cal3 = calculate.A / calculate.B;
                calculate.Cal4 = calculate.A % calculate.B;
                ViewBag.C = "Thuong: "+ calculate.Cal3 + " du: " +calculate.Cal4;
            }
                return View("Index", calculate);
    }
}
}
