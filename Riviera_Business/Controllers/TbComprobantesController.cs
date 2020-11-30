using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbComprobantesController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbComprobantes.ToList();
            foreach(TbComprobantes ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdControlNavigation = context.TbControl.Where(tc => tc.IdMovimiento == ti.IdControl).FirstOrDefault();
            }
            return View();
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
            ViewBag.Control = context.TbControl.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = c.LineaCaptura, Value = c.IdMovimiento.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbComprobantes a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbComprobantes.Add(a);
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
            ViewBag.Control = context.TbControl.Select(c => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = c.LineaCaptura, Value = c.IdMovimiento.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            if (context.TbComprobantes.Where(tc=> tc.IdComprobantes == id).First() is TbComprobantes e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbComprobantes a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbComprobantes.FirstOrDefault(tc => tc.IdComprobantes == a.IdComprobantes);
                if(objectEdit != null)
                {
                    objectEdit.BajaCambProp = a.BajaCambProp;
                    objectEdit.ComprobantesPago = a.ComprobantesPago;
                    objectEdit.ComprobarId = a.ComprobarId;
                    objectEdit.ConstamcoaFiscal = a.ConstamcoaFiscal;
                    objectEdit.Contrato = a.Contrato;
                    objectEdit.CurpPf = a.CurpPf;
                    objectEdit.IdControl = a.IdControl;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.LeyAntilavado = a.LeyAntilavado;
                    context.TbComprobantes.Update(objectEdit);
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
