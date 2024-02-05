using System;
using System.Reflection.Metadata;
using System.Reflection.Emit;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class SoSanhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SoSanh(SoSanh soSanh)
        {
            if(soSanh.STT1 > soSanh.STT2){
                ViewBag.A = "so thu 1 lon hon so thu 2";
            }else if (soSanh.STT1 < soSanh.STT2){
                ViewBag.B = "so thu 1 be hon so thu 2";
            }else{
                ViewBag.C=" 2 so bang nhau";
            }
                
                return View("Index", soSanh);
    }
}
}
