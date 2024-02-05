using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;

public class EmployeeController : Controller{
    public IActionResult Index(){
        return View();
    }
    [HttpPost]

    public IActionResult Index(Employee emp){
            String str = "Mã Nhân Viên: " + emp.EmployeeID + " - Tên Nhân Viên: " + emp.EmployeeName.ToUpper() + " -  Tuổi: " + emp.Tuoi + " - Lương: "+ emp.Luong;
        ViewBag.A = str;
        return View();
    }
}