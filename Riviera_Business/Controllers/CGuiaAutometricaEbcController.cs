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
                ti.IdVersionNavigation = context.CVersionCarro.Where(te => te.IdVersionCarro == ti.IdVersion).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where(mar => mar.IdMarcaCarro == ti.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
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
            
        }

        // GET: HomeController1/Create
        public ActionResult CreaAutometrica()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.VersionCarro, Value = s.IdVersionCarro.ToString() });
            return View();
        }

        public ActionResult CreaEBC()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.Descripcion, Value = s.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.VersionCarro, Value = s.IdVersionCarro.ToString() });
            return View();
        }
        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreaEBC(CGuiaAutometricaEbc a)
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreaAutometrica(CGuiaAutometricaEbc a)
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
            ViewBag.Version = context.CVersionCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.VersionCarro, Value = s.IdVersionCarro.ToString() });
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
                    objectEdit.IdVersion = a.IdVersion;
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
