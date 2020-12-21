﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class TbSeguimientoController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbSeguimiento.ToList();
            foreach (TbSeguimiento ti in list)
            {
                ti.CMedioPublicitarioNavigation = context.CMedioPublicitario.Where(me => me.IdMedioPublicitario == ti.CMedioPublicitario).FirstOrDefault();
                ti.IdCarroNavigation = context.TbCarros.Where(car => car.IdCarros == ti.IdCarro).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdCarroNavigation.IdVersion).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdCarroNavigation.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();
                ti.IdEstadoNavigation = context.CEstados.Where(es => es.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdAsesorNavigation = context.CAsesores.Where(ase => ase.IdAsesores == ti.IdAsesor).FirstOrDefault();
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Mediopubli = context.CMedioPublicitario.Select(mp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mp.Nombre, Value = mp.IdMedioPublicitario.ToString() });
            if (context.TbSeguimiento.Where(se => se.IdSeguimiento == id).First() is TbSeguimiento e)
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
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ver=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text =ver.VersionCarro,Value=ver.IdVersionCarro.ToString() } );
            ViewBag.Mediopubli = context.CMedioPublicitario.Select(mp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mp.Nombre, Value = mp.IdMedioPublicitario.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            return View();
        }

        [HttpPost]
        public CVersionCarro RecuperarVersion(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            TbCarros carrito = context.TbCarros.Where(car => car.IdCarros == id).FirstOrDefault();
            CVersionCarro cversion = context.CVersionCarro.Where(cver => cver.IdVersionCarro == carrito.IdVersion).FirstOrDefault();
            carrito.IdVersionNavigation = null;
            return cversion;
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbSeguimiento a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbSeguimiento.Add(a);
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
            ViewBag.Carros = context.TbCarros.Select(car => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = car.NoSerie, Value = car.IdCarros.ToString() });
            ViewBag.Mediopubli = context.CMedioPublicitario.Select(mp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mp.Nombre, Value = mp.IdMedioPublicitario.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            if (context.TbSeguimiento.Where(se=> se.IdSeguimiento == id).First() is TbSeguimiento e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbSeguimiento a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbSeguimiento.FirstOrDefault(se=>se.IdSeguimiento == a.IdSeguimiento);
                if (objectEdit!= null)
                {
                    objectEdit.Anticipo = a.Anticipo;
                    objectEdit.IdAsesor = a.IdAsesor;
                    objectEdit.Asistio = a.Asistio;
                    objectEdit.Cita = a.Cita;
                    objectEdit.CMedioPublicitario = a.CMedioPublicitario;
                    objectEdit.Comentarios = a.Comentarios;
                    objectEdit.Contesto = a.Contesto;
                    objectEdit.Correo = a.Correo;
                    objectEdit.DiaSemana = a.DiaSemana;
                    objectEdit.Fecha = a.Fecha;
                    objectEdit.IdCarro = a.IdCarro;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.IdTipoCompra = a.IdTipoCompra;
                    objectEdit.NombreCompleto = a.NombreCompleto;
                    objectEdit.PruebaManejo = a.PruebaManejo;
                    objectEdit.Sexo = a.Sexo;
                    objectEdit.Telefono = a.Telefono;
                    objectEdit.Toma = a.Toma;
                    objectEdit.Venta = a.Venta;
                    context.TbSeguimiento.Update(objectEdit);
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
