using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DuAnDauTien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DuAnDauTien.Controllers
{
    public class RegisterController : Controller
    {
        private IHostingEnvironment hosting;
        public RegisterController(IHostingEnvironment _hosing)
        {
            hosting = _hosing;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy(PersonViewModel m, IFormFile FHinh)
        {
            if (FHinh != null)
            {
                //xử lý upload
                string filename = FHinh.FileName;
                // string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                string path = Path.Combine(hosting.WebRootPath, "images");
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    //sao chép lên server
                    FHinh.CopyTo(filestream);
                }
                m.Picture = filename;
            }
            return View(m);
        }
    }
}