using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;
/// <summary>
/// //////////////////////////////////////////////PENDIENTE///////////////////////////////////////
/// </summary>
namespace Riviera_Business.Controllers
{
    public class TbControlController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbControl.ToList();
            foreach (TbControl ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(ce=> ce.IdEstados ==ti.IdEstado).FirstOrDefault();
                ti.IdFormaPagoNavigation = context.CFormaPago.Where(fp => fp.IdFormaPago == ti.IdFormaPago).FirstOrDefault();
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
            ViewBag.Estados = context.CEstados.Select(es=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=es.Descripcion,Value=es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });

            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                context.TbControl.Add(a);
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
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            if (context.TbControl.Where(tc =>tc.IdMovimiento ==id).First() is TbControl e)
            {
                return View(e);
            }
            return NotFound();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                var objectEdit = context.TbControl.FirstOrDefault(tc => tc.IdMovimiento == a.IdMovimiento);
                if (objectEdit!=null)
                {
                    objectEdit.Banco = a.Banco;
                    objectEdit.ClienteVenta = a.ClienteVenta;
                    objectEdit.CompraVenta = a.CompraVenta;
                    objectEdit.Factura = a.Factura;
                    objectEdit.FechaActual = a.FechaActual;
                    objectEdit.FechaES = a.FechaES;
                    objectEdit.FechaFactura = a.FechaFactura;
                    objectEdit.IdCarros = a.IdCarros;
                    objectEdit.IdCliente = a.IdCliente;
                    objectEdit.IdEstado = a.IdEstado;
                    objectEdit.IdFormaPago = a.IdFormaPago;
                    objectEdit.Isan = a.Isan;
                    objectEdit.Iva = a.Iva;
                    objectEdit.LineaCaptura = a.LineaCaptura;
                    objectEdit.Medias = a.Medias;
                    objectEdit.MetodoPago = a.MetodoPago;
                    objectEdit.Pagada = a.Pagada;
                    objectEdit.PNeto = a.PNeto;
                    objectEdit.PrecioPactado = a.PrecioPactado;
                    objectEdit.Repuve = a.Repuve;
                    objectEdit.SubTotal = a.SubTotal;
                    objectEdit.TipoVenta = a.TipoVenta;
                    objectEdit.Total = a.Total;
                    objectEdit.VoBoFacturarSat = a.VoBoFacturarSat;
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
