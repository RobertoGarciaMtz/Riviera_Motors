using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class CVersionCarroController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CVersionCarro.ToList();
            foreach (CVersionCarro ti in list)
            {
                ti.IdModeloNavigation = context.CModeloCarro.Where(te => te.IdModeloCarro == ti.IdModelo).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.CVersionCarro.Where(s => s.IdVersionCarro == id).First() is CVersionCarro e)
            {
                return View(e);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Modelo = context.CModeloCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.ModeloCarro, Value = s.IdModeloCarro.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CVersionCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CVersionCarro.Add(a);
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
            ViewBag.Modelo = context.CModeloCarro.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.ModeloCarro, Value = s.IdModeloCarro.ToString() });
            if(context.CVersionCarro.Where(s=>s.IdVersionCarro == id).First() is CVersionCarro e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CVersionCarro a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CVersionCarro.FirstOrDefault(cv => cv.IdVersionCarro == a.IdVersionCarro);
                if (objectEdit != null)
                {
                    objectEdit.VersionCarro = a.VersionCarro;
                    objectEdit.IdModelo = a.IdModelo;
                    context.CVersionCarro.Update(objectEdit);
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
