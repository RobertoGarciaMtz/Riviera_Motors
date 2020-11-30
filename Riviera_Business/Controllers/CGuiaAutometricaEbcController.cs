using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class CGuiaAutometricaEbcController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CGuiaAutometricaEbc.ToList();
            foreach (CGuiaAutometricaEbc ti in list)
            {
                ti.IdCarroNavigation = context.TbCarros.Where(te => te.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            
            if (context.CGuiaAutometricaEbc.Where(s => s.IdGuiaAutometrica == id).First() is CGuiaAutometricaEbc e)
            {
                return View(id);
            }
            return NotFound();
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            ViewBag.Carros = context.TbCarros.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.NoSerie, Value = s.IdCarros.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CGuiaAutometricaEbc a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CGuiaAutometricaEbc.Add(a);
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
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            ViewBag.Carros = context.TbCarros.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.NoSerie, Value = s.IdCarros.ToString() });
            if (context.CGuiaAutometricaEbc.Where(s => s.IdGuiaAutometrica == id).First() is CGuiaAutometricaEbc e)
            {
                return View(id);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,CGuiaAutometricaEbc a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CGuiaAutometricaEbc.FirstOrDefault(ce => ce.IdGuiaAutometrica == a.IdGuiaAutometrica);
                if(objectEdit != null)
                {
                    objectEdit.Toma = a.Toma;
                    objectEdit.Venta = a.Venta;
                    objectEdit.Media = a.Media;
                    objectEdit.IdCarro = a.IdCarro;
                    context.CGuiaAutometricaEbc.Update(objectEdit);
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
