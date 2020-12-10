﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Riviera_Business.Controllers
{
    public class CuentasPendientesCPController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.CuentasPendientesCP.ToList();
            foreach (CuentasPendientesCP ti in list)
            {
                ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdConceptoNavigation = context.CConcepto.Where(con => con.IdCConcepto == ti.IdConcepto).FirstOrDefault();
                    ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            
            if (context.CuentasPendientesCP.Where(cu => cu.IdCuentaPendiente == id).First() is CuentasPendientesCP e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult CuentasCobrar()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto,Value = con.IdCConcepto.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            return View();
        }

        public ActionResult CuentasPagar()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto, Value = con.IdCConcepto.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            return View();
        }
        public ActionResult OtrasCuentas()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto, Value = con.IdCConcepto.ToString() });
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CuentasCobrar(CuentasPendientesCP a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.CuentasPendientesCP.Add(a);
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
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Concepto = context.CConcepto.Select(con => new SelectListItem { Text = con.DescripcionConcepto, Value = con.IdCConcepto.ToString() });
            var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
                .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
            ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
            if (context.CuentasPendientesCP.Where(cu=>cu.IdCuentaPendiente== id).First() is CuentasPendientesCP e) 
            { 
            return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CuentasPendientesCP a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var ObjectEdit = context.CuentasPendientesCP.FirstOrDefault(cu => cu.IdCuentaPendiente == id);
                if (ObjectEdit != null)
                {
                    ObjectEdit.Anticipo = a.Anticipo;
                    ObjectEdit.CuentasCobrarPagarOtras = a.CuentasCobrarPagarOtras;
                    ObjectEdit.Detalle = a.Detalle;
                    ObjectEdit.Fecha = a.Fecha;
                    ObjectEdit.Folio = a.Folio;
                    ObjectEdit.IdCarro = a.IdCarro;
                    ObjectEdit.IdCliente = a.IdCliente;
                    ObjectEdit.IdConcepto = a.IdConcepto;
                    ObjectEdit.IdEstado = a.IdEstado;
                    ObjectEdit.IdProveedor = a.IdProveedor;
                    ObjectEdit.Importe = a.Importe;
                    context.CuentasPendientesCP.Update(a);
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
