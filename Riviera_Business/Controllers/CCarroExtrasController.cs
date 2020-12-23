﻿using System;
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
            ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
            ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
            ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
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
        var lista = context.TbCarros.Where(x => x.IdCarros >= 0)
            .Select(x => new { noserie = x.IdCarros.ToString(), desc = x.IdCarros.ToString() + "-NumeroSerie:" + x.NoSerie + "-Color:" + x.ColorExt + "-NumMotor:" + x.NoMotor });
        ViewBag.Caracarro = new SelectList(lista, "noserie", "desc");
        return View();
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



    [HttpPost]
    public CVersionCarro RecuperarVersion(int id)
    {
        var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
        TbCarros carrito = context.TbCarros.Where(car => car.IdCarros == id).FirstOrDefault();
        CVersionCarro cversion = context.CVersionCarro.Where(cver => cver.IdVersionCarro == carrito.IdVersion).FirstOrDefault();
        if (cversion != null)
        {
            cversion.TbCarros = null;
            cversion.IdModeloNavigation = null;
            cversion.CGuiaAutometricaEbc = null;
        }        
        return cversion;
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

}
