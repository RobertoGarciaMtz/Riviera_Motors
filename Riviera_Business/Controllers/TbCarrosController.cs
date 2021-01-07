using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Riviera_Business.Controllers
{
    public class TbCarrosController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbCarros.ToList();
            foreach (TbCarros ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(tc => tc.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdVersionNavigation = context.CVersionCarro.Where(tc => tc.IdVersionCarro == ti.IdVersion).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation = context.CModeloCarro.Where(mod => mod.IdModeloCarro == ti.IdVersionNavigation.IdModelo).FirstOrDefault();
                ti.IdVersionNavigation.IdModeloNavigation.IdMarcaNavigation = context.CMarcaCarro.Where
                    (mar => mar.IdMarcaCarro == ti.IdVersionNavigation.IdModeloNavigation.IdMarca).FirstOrDefault();

                /*
                 if(ti.TipoCompraCanal== 1){//1 Interagencias
                    ti.IdProveedor= context.TbDatosPersona.Where=(dp=>dp.Id)
                }
                if(ti.TipoCompraCanal ==2){ // 2 Retail
                }
                 */
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            if (context.TbCarros.Where(tc => tc.IdCarros == id).First() is TbCarros e)
            {
                return View(e);
            }
            return NotFound();
        }
        /*-------------------------------------------------------
         */
        [HttpGet]
        public ActionResult Extras()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            ViewBag.Modelo = context.CModeloCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.ModeloCarro, Value = mo.IdModeloCarro.ToString() });
            ViewBag.Marca = context.CMarcaCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.NombreMarca, Value = mo.IdMarcaCarro.ToString() });
            return View();
        }
        [HttpPost]
        public ActionResult Extras(ZMMVCarro copia)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var carrito = context.TbCarros.LastOrDefault();
                TbCarros objectEdit= new TbCarros();
                if (carrito != null)
                {
                    objectEdit.Modelo = copia.Modelo;
                    objectEdit.Antiguedad = copia.Antiguedad;
                    objectEdit.TipoCompraCanal = copia.TipoCompraCanal;
                    objectEdit.ClaveVehicular = copia.ClaveVehicular;
                    objectEdit.IdVersion = copia.IdVersion;
                    objectEdit.ColorExt = copia.ColorExt;
                    objectEdit.ColorInt = copia.ColorInt;
                    objectEdit.DuenoAnterior = copia.DuenoAnterior;
                    objectEdit.FechaFactToma = copia.FechaFactToma;
                    objectEdit.FolioFiscal = copia.FolioFiscal;
                    objectEdit.IdEstado = copia.IdEstado;
                    objectEdit.Kms = copia.Kms;
                    objectEdit.MvaOpc = copia.MvaOpc;
                    objectEdit.NoMotor = copia.NoMotor;
                    objectEdit.NoSerie = copia.NoSerie;
                    objectEdit.NumEconomicoOpc = copia.NumEconomicoOpc;
                    objectEdit.Origen = copia.Origen;
                    objectEdit.PropuestaCliente = copia.PropuestaCliente;
                    objectEdit.Transmicion = copia.Transmicion;
                    objectEdit.IdProveedor = copia.IdProveedor;
                    objectEdit.Ubicacion = copia.Ubicacion;
                    objectEdit.FechaOferta = copia.FechaOferta;
                    /*------------------------------------------------------------*/
                    context.TbCarros.Add(objectEdit);
                    context.SaveChanges();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(copia);
            }
        }
        /*
         -------------------------------------------------*/
        // GET: HomeController1/Create
        public ActionResult Create()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            ViewBag.Modelo = context.CModeloCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.ModeloCarro, Value = mo.IdModeloCarro.ToString() });
            ViewBag.Marca = context.CMarcaCarro.Select(mo => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = mo.NombreMarca, Value = mo.IdMarcaCarro.ToString() });
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
                Console.WriteLine("Valor del id" + a.IdVersion);
                Console.WriteLine("Aqui si entramos");
                Console.WriteLine("Aqui si entramos"+a);
                context.SaveChanges();
                Console.WriteLine("Aqui no entramos ");
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine("Aqui si entramos" + e);
                return View(a);
            }
        }



        // POST: HomeController1/Create
        [HttpPost]
        public List<CModeloCarro> RecuperarModelo1(int id){
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<CModeloCarro> cModelos = new List<CModeloCarro>();
            var list = context.CModeloCarro.Where(x => x.IdMarca == id).ToList();
            Console.WriteLine(list);
            foreach (CModeloCarro v in list)
            {
                v.IdMarcaNavigation = null;
                v.CVersionCarro = null;
            }
            return list;
        }

        [HttpPost]
        public List<CVersionCarro> RecuperarVersion1(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<CVersionCarro> cVersion = new List<CVersionCarro>();
            var list = context.CVersionCarro.Where(y => y.IdModelo == id).ToList();
            foreach (CVersionCarro v in list)
            {
                v.IdModeloNavigation = null;
                v.CGuiaAutometricaEbc = null;
                v.TbCarros = null;
            }
            Console.WriteLine(list);
            return list;
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Version = context.CVersionCarro.Select(ma => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ma.VersionCarro, Value = ma.IdVersionCarro.ToString() });
            if (context.TbCarros.Where(tc => tc.IdCarros == id).First() is TbCarros e)
            {
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
                    objectEdit.Modelo = a.Modelo;
                    objectEdit.Antiguedad = a.Antiguedad;
                    objectEdit.TipoCompraCanal = a.TipoCompraCanal;
                    objectEdit.ClaveVehicular = a.ClaveVehicular;
                    objectEdit.IdVersion = a.IdVersion;
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
                    objectEdit.Transmicion = a.Transmicion;
                    objectEdit.IdProveedor = a.IdProveedor;
                    objectEdit.Ubicacion = a.Ubicacion;
                    objectEdit.FechaOferta = a.FechaOferta;
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

        public ActionResult Delete(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (context.TbCarros.Where(tc => tc.IdCarros == id).First() is TbCarros e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, TbCarros a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                TbCarros objectdel = a;

                context.TbCarros.Remove(objectdel);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
