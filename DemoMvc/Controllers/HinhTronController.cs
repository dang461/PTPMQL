using System.Reflection.Emit;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using BS_HS.Models;

namespace HinhTronController.Controllers
{
    public class HinhTronController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(Tinh model)
        {
                // Tính diện tích
                model.DienTich = Tinh.PI * model.BK * model.BK;
                ViewBag.A = "Dien tich la: " + model.DienTich;

                return View("Index", model);

    }
}
}