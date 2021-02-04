using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanWeb.Controllers
{
    public class ProfesionController : Controller
    {
        // GET: ProfesionController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult ObtenerDatos(string nombre, string apellido)
        {
            //To Do: Ejecutar la suma con la libreria de negocio matematica para obetener suma
            var datos = "juan";
            ViewBag.Datos = datos;
            return View();
        }

        // GET: ProfesionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfesionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfesionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfesionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfesionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfesionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfesionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
