using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;



namespace Riviera_Business.Controllers
{
    public class CPreAcondicionamientoController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CPreAcondicionamiento.ToList();
            foreach(CPreAcondicionamiento ti in list)
            {
                ti.TbCarrosIdCarrosNavigation = context.TbCarros.Where(te => te.IdCarros == ti.TbCarrosIdCarros).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            
            if (context.CPreAcondicionamiento.Where(s => s.IdPreAcondicionamiento == id).First() is CPreAcondicionamiento e)
            {

                return View(e);
            }
            return NotFound();
            
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Carros = context.TbCarros.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.NoSerie, Value = s.IdCarros.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CPreAcondicionamiento a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CPreAcondicionamiento.Add(a);
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
            ViewBag.Carros = context.TbCarros.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = s.NoSerie, Value = s.IdCarros.ToString() });
            if (context.CPreAcondicionamiento.Where(s => s.IdPreAcondicionamiento == id).First() is CPreAcondicionamiento e)
            {

                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CPreAcondicionamiento a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.CPreAcondicionamiento.FirstOrDefault(ce => ce.IdPreAcondicionamiento == a.IdPreAcondicionamiento);
                if(objectEdit != null)
                {
                    
                    objectEdit.Esteticos = a.Esteticos;
                    objectEdit.Hyp = a.Hyp;
                    objectEdit.Mec = a.Mec;
                    objectEdit.Refac = a.Refac;
                    objectEdit.TbCarrosIdCarros = a.TbCarrosIdCarros;
                    objectEdit.Trasl = a.Trasl;
                    objectEdit.TbCarrosIdCarros = a.TbCarrosIdCarros;
                    context.CPreAcondicionamiento.Update(objectEdit);
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
