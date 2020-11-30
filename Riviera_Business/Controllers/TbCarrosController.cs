using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
/// <summary>
/// /////////////////////////////////////////////////////Pendiente////////////////////////////7
/// </summary>
namespace Riviera_Business.Controllers
{
    public class TbCarrosController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbCarros.ToList();
            foreach(TbCarros ti in list)
                {
                ti.IdEstadoNavigation = context.CEstados.Where(tc => tc.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.CMarcaCarroIdMarcaCarroNavigation = context.CMarcaCarro.Where(tc => tc.IdMarcaCarro == ti.CMarcaCarroIdMarcaCarro).FirstOrDefault();
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
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=es.Descripcion , Value =es.IdEstados.ToString() });
            ViewBag.Marca = context.CMarcaCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.NombreMarca, Value = ma.IdMarcaCarro.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbCarros a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                    context.TbCarros.Add(a);
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
            ViewBag.Marca = context.CMarcaCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.NombreMarca, Value = ma.IdMarcaCarro.ToString() });
            if (context.TbCarros.Where(tc=> tc.IdCarros ==id).First() is TbCarros e) { 
            return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbCarros a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbCarros.FirstOrDefault(tc => tc.IdCarros == a.IdCarros);
                if (objectEdit != null)
                {
                    objectEdit.Ano = a.Ano;
                    objectEdit.Antiguedad = a.Antiguedad;
                    objectEdit.Canal = a.Canal;
                    objectEdit.ClaveVehicular = a.ClaveVehicular;
                    objectEdit.CMarcaCarroIdMarcaCarro = a.CMarcaCarroIdMarcaCarro;
                    objectEdit.ColorExt = a.ColorExt;
                    objectEdit.ColorInt = a.ColorInt;
                    objectEdit.DuenoAnterior = a.DuenoAnterior;
                    objectEdit.FechaFactToma = a.FechaFactToma;
                    objectEdit.FolioFiscal = a.FolioFiscal;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.Kms = a.Kms;
                    objectEdit.MvaOpc = a.MvaOpc;
                    objectEdit.NoMotor = a.NoMotor;
                    objectEdit.NoSerie = a.NoSerie;
                    objectEdit.NumEconomicoOpc = a.NumEconomicoOpc;
                    objectEdit.Origen = a.Origen;
                    objectEdit.PropuestaCliente = a.PropuestaCliente;
                    objectEdit.TipoCompra = a.TipoCompra;
                    objectEdit.Transmicion = a.Transmicion;
                    objectEdit.IdProveedor = a.IdProveedor;
                    objectEdit.Ubicacion = a.Ubicacion;
                    context.TbCarros.Update(objectEdit);

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
