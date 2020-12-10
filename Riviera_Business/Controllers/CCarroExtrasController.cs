using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Riviera_Business.Models;
public class CCarroExtrasController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
        var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
        var list = context.CCarroExtra.ToList();
        foreach (CCarroExtra ti in list)
            {
            ti.IdEstadoNavigation = context.CEstados.Where(te => te.IdEstados == ti.IdEstado).FirstOrDefault();
            ti.IdCarroNavigation = context.TbCarros.Where(ce => ce.IdCarros == ti.IdCarro).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
        var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
        if (context.CCarroExtra.Where(s => s.IdCarroExtra == id).First() is CCarroExtra e)
        {
            return View(e);
        }
        return NotFound();
    }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
        var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
        ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
        var  lista = context.TbCarros.Where(x => x.IdCarros >=0 )
            .Select(x => new {noserie=x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
        ViewBag.Caracarro = new SelectList(lista, "noserie","desc");
        return View();
        }
[HttpGet]
    public List<CVersionCarro> RecuperarVersion1(int id)
    {
        var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
        var list = context.CVersionCarro.ToList();
        List<CVersionCarro> cModelos = new List<CVersionCarro>();
        foreach (CVersionCarro lista in list)
        {
            if (lista.IdVersionCarro == id) { 
                cModelos.Add(lista);
                return cModelos;
            }
        }
        
        return null;

    }
    // POST: HomeController1/Create
    [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CCarroExtra a)
        {
            try
            {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            context.CCarroExtra.Add(a);
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
        var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
            .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
        ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
        if (context.CCarroExtra.Where(s => s.IdCarroExtra == id).First() is CCarroExtra e)
        {
            return View(e);
        }
        return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CCarroExtra a)
        {
            try
            {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var ObjectEdit = context.CCarroExtra.FirstOrDefault(ce => ce.IdCarroExtra == a.IdCarroExtra);
            if (ObjectEdit != null)
            {
                ObjectEdit.Antena = a.Antena;
                ObjectEdit.CarnetServicio = a.CarnetServicio;
                ObjectEdit.Duplicado = a.Duplicado;
                ObjectEdit.Herramientas = a.Herramientas;
                ObjectEdit.LlantaRefaccion = a.LlantaRefaccion;
                ObjectEdit.IdEstado = a.IdEstado;
                ObjectEdit.Manuales = a.Manuales;
                ObjectEdit.Gato = a.Gato;
                ObjectEdit.IdEstado = a.IdEstado;
                ObjectEdit.IdCarro = a.IdCarro;
                context.CCarroExtra.Update(ObjectEdit);
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

