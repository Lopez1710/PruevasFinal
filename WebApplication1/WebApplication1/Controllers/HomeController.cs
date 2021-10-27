using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entidades;
using WebApplication1.Models;
using WebApplication1.Servicio;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IUsuario iusuario;
        IRol irol;
        IIMG iimg;

        public HomeController(ILogger<HomeController> logger, IUsuario iusuario,IRol irol,IIMG iimg)
        {
            this.iusuario = iusuario;
            this.irol = irol;
            this.iimg = iimg;
            _logger = logger;

        }

        public IActionResult Index()
        {
            List<Roles> ls = irol.Listar();
            List<SelectListItem> item = new List<SelectListItem>();
            foreach (var lista in ls) {
                item.Add(
                     new SelectListItem
                     {
                         Text = lista.Rol,
                         Value = lista.RolID.ToString(),

                     }
                     );

                ViewBag.ls = item;
            }
            List<Imagenes> img = iimg.listado();
            ViewBag.imgs = img;
            return View();
        }
        [HttpPost]
        public IActionResult Index(Usuarios usr)
        {
            Usuarios us = new Usuarios();
            us.Nick = usr.Nick;
            us.Email = usr.Email;
            us.Pass = usr.Pass;
            us.RolID = usr.RolID;
            iusuario.Insert(us);

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
