using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToditoRentas.Models;

namespace ToditoRentas.Controllers
{
    public class PrincipalController : Controller
    {
        ToditoRentasEntities db = new ToditoRentasEntities();

        // GET: Principal
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Inicio()
        {
            try
            {
                ViewData["Categorias"] = db.Categoria.ToList();
                return View();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return View();
            }
        }
    }
}