using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuAnDauTien.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //Cách 1: Lấy tham số thông qua Request
        //public IActionResult TinhToan()
        //{
        //    //Lấy tham số
        //    int x = int.Parse(Request.Form["so1"]);
        //    int y = int.Parse(Request.Form["so2"]);
        //    string pheptinh = Request.Form["pheptinh"];
        //    double kq=0;
        //    //Xử Lý
        //    switch (pheptinh)
        //    {
        //        case "+": kq = x + y; break;
        //        case "-": kq = x - y; break;
        //        case "*": kq = x * y; break;
        //        case "/": kq = x / y; break;
        //    }
        //    //Truyền dữ liệu cho View bằng ViewBag
        //    ViewBag.KQ = kq;
        //    return View("KetQua");
        //}
        //Cách 2: Lấy tham số thông qua đối số
        public IActionResult TinhToan(int so1,int so2,string pheptinh)
        {
            //Lấy tham số
            double kq = 0;
            //Xử Lý
            switch (pheptinh)
            {
                case "+": kq = so1 + so2; break;
                case "-": kq = so1 - so2; break;
                case "*": kq = so1 * so2; break;
                case "/": kq = so1 / so2; break;
            }
            //Truyền dữ liệu cho View bằng ViewBag
            ViewBag.KQ = kq;
            return View("Index");


        }
    }
}
