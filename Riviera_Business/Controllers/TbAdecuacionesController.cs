using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;


namespace Riviera_Business.Controllers
{
    public class TbAdecuacionesController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbAdecuaciones.ToList();
            foreach (TbAdecuaciones ti in list)
            {
                ti.IdCarroNavigation = context.TbCarros.Where(ta => ta.IdCarros == ti.IdCarro).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(ta => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ta.NoSerie, Value = ta.IdCarros.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbAdecuaciones a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbAdecuaciones.Add(a);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(ta => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ta.NoSerie, Value = ta.IdCarros.ToString() });
            if(context.TbAdecuaciones.Where(ta=>ta.IdAdecuaciones ==id).First() is TbAdecuaciones e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbAdecuaciones a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbAdecuaciones.FirstOrDefault(ta => ta.IdAdecuaciones == a.IdAdecuaciones);
                if (objectEdit!=null)
                {
                    objectEdit.Fecha = a.Fecha;
                    objectEdit.IdCarro = a.IdCarro;
                    objectEdit.Lavado = a.Lavado;
                    objectEdit.LavadoVestiduras = a.LavadoVestiduras;
                    objectEdit.Mecanica = a.Mecanica;
                    objectEdit.Motor = a.Motor;
                    objectEdit.Otros = a.Otros;
                    objectEdit.Preparacion = a.Preparacion;
                    objectEdit.PulidoEncerado = a.PulidoEncerado;
                    objectEdit.Traslado = a.Traslado;
                    context.TbAdecuaciones.Update(objectEdit);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
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
