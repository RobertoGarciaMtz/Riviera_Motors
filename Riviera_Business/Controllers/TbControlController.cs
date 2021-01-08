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
            var list = context.TbControl.Where(lis=>lis.CompraVenta==2).ToList();
            foreach (TbControl ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(ce=> ce.IdEstados ==ti.IdEstado).FirstOrDefault();
                ti.IdFormaPagoNavigation = context.CFormaPago.Where(fp => fp.IdFormaPago == ti.IdFormaPago).FirstOrDefault();
                ti.IdBancoNavigation = context.CBanco.Where(bc => bc.IdBanco == bc.IdBanco).FirstOrDefault();

                /*
            //if (ti.TipoVenta == 1)
            //{
              //  var persona = context.TbDatosPersona.Where(dp => dp.IdDatosPersona == ti.IdProveedor).FirstOrDefault();
                //ti.TbControl.IdCliente = context.TbDatosPersona.IdDatosPersona;

            }
            if(ti.TipoVenta==2){
                var persona = contextTbDatosPersonaMoral.Where(dpm=>dpm.IdDatosPm==ti.IdProveedor).FirstOrDefault();
                ti.TbControl.IdCliente = context.TbDatosPersonaMoral.IdDatosPM;
                }
             */
            }
            return View(list);
        }

        public ActionResult IndexdeCompras()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbControl.Where(li=>li.CompraVenta==1).ToList();
            foreach (TbControl ti in list)
            {
                ti.IdEstadoNavigation = context.CEstados.Where(ce => ce.IdEstados == ti.IdEstado).FirstOrDefault();
                ti.IdFormaPagoNavigation = context.CFormaPago.Where(fp => fp.IdFormaPago == ti.IdFormaPago).FirstOrDefault();
                ti.IdBancoNavigation = context.CBanco.Where(bc => bc.IdBanco == bc.IdBanco).FirstOrDefault();
                ///
                //if (ti.TipoCompraCanal == 1)
                //{
                //  var persona = context.TbDatosPersona.Where(dp => dp.IdDatosPersona == ti.IdProveedor).FirstOrDefault();
                //ti.persona.IdDatosPersona = persona.IdDatosPersona;
                //}
            }
            return View(list);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            if (context.TbControl.Where(tc => tc.IdMovimiento == id).First() is TbControl e)
            {
                return View(e);
            }
            return NotFound();
        }

        // GET: HomeController1/Create
        public ActionResult CompraAut()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es=> new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem {Text=es.Descripcion,Value=es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompraAut(TbControl a)
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
        /// <summary>
        /// ///////////////////////////////////////////////////// fase beta
        public ActionResult VentaRetail()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VentaRetail(TbControl a)
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

        /// </summary>
        /// <returns></returns>


        public ActionResult VentaAut()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            ViewBag.Asesor = context.CAsesores.Select(ase => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = ase.Nombre, Value = ase.IdAsesores.ToString() });
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult VentaAut(TbControl a)
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


        /// <summary>
        /// ///////////POSIBLE FUNCION FUTURA//////////////////

        /// <returns></returns>
        [HttpGet]
        public List<TbControl> Esconder(int opcion)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            if (opcion == 1)
            {
                List<TbControl> comprados = new List<TbControl>();
                var lista1 = context.TbControl.Where(cont => cont.CompraVenta == opcion).ToList();
                foreach (TbControl ti in lista1)
                {
                    ti.IdAsesorVentaNavigation = null;
                    ti.IdBancoNavigation = null;
                    ti.IdEstadoNavigation = null;
                    ti.IdFormaPagoNavigation = null;
                    ti.TbCarrosTransaccion = null;
                    ti.TbSeguro = null;
                }
                return lista1;
            }
            if (opcion == 2)
            {
                var lista2 = context.TbControl.Where(cont2 => cont2.CompraVenta == opcion).ToList();
                foreach (TbControl ti in lista2)
                {
                    ti.IdAsesorVentaNavigation = null;
                    ti.IdBancoNavigation = null;
                    ti.IdEstadoNavigation = null;
                    ti.IdFormaPagoNavigation = null;
                    ti.TbCarrosTransaccion = null;
                    ti.TbSeguro = null;
                }
                return lista2;
            }
            return null;
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
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
                    objectEdit.BajaCambProp = a.BajaCambProp;
                    objectEdit.CantidadDebida = a.CantidadDebida;
                    objectEdit.ClienteVenta = a.ClienteVenta;
                    objectEdit.CompraVenta = a.CompraVenta;
                    objectEdit.ComprobantesPago = a.ComprobantesPago;
                    objectEdit.ComprobarId = a.ComprobarId;
                    objectEdit.ConstanciaFiscal = a.ConstanciaFiscal;
                    objectEdit.Contrato = a.Contrato;
                    objectEdit.CurpPf = a.CurpPf;
                    objectEdit.Debiendo = a.Debiendo;
                    objectEdit.FechaES = a.FechaES;
                    objectEdit.FechaFactura = a.FechaFactura;
                    objectEdit.FechaFacturaToma = a.FechaFacturaToma;
                    objectEdit.FolioFiscal = a.FolioFiscal;
                    objectEdit.GastoTotalEnCarro = a.GastoTotalEnCarro;
                    objectEdit.IdBanco = a.IdBanco;
                    objectEdit.IdCarros = a.IdCarros;
                    objectEdit.IdCliente = a.IdCliente;
                    objectEdit.IdFormaPago = a.IdFormaPago;
                    objectEdit.Iva = a.Iva;
                    objectEdit.LeyAntilavado = a.LeyAntilavado;
                    objectEdit.MetodoPago = a.MetodoPago;
                    objectEdit.NoFacturaArv = a.NoFacturaArv;
                    objectEdit.PagadaCobrada = a.PagadaCobrada;
                    objectEdit.PrecioPactado = a.PrecioPactado;
                    objectEdit.SubTotal = a.SubTotal;
                    objectEdit.TipoVenta = a.TipoVenta;
                    objectEdit.Total = a.Total;
                    objectEdit.VoBoFacturarSat = a.VoBoFacturarSat;
                    objectEdit.VoBoLeyAntiLavado = a.VoBoLeyAntiLavado;
                    
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

         public ActionResult LlenadoExtra()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.Estados = context.CEstados.Select(es => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = es.Descripcion, Value = es.IdEstados.ToString() });
            ViewBag.Formapago = context.CFormaPago.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdFormaPago.ToString() });
            ViewBag.Banco = context.CBanco.Select(fp => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem { Text = fp.Nombre, Value = fp.IdBanco.ToString() });
            return View();
        }

        [HttpPost]
        public ActionResult LlenadoExtra(TbControl a)
        {
            try
            {
                var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
                TbControl copia = new TbControl();
                copia.Anticipo = a.Anticipo;
                copia.AnticipoSN = a.AnticipoSN;
                copia.BajaCambProp = a.BajaCambProp;
                copia.CantidadDebida = a.CantidadDebida;
                copia.ClienteVenta = a.ClienteVenta;
                copia.CompraVenta = a.CompraVenta;
                copia.ComprobantesPago = a.ComprobantesPago;
                copia.ComprobarId = a.ComprobarId;
                copia.ConstanciaFiscal = a.ConstanciaFiscal;
                copia.Contrato = a.Contrato;
                copia.CurpPf = a.CurpPf;
                copia.Debiendo = a.Debiendo;
                copia.FechaES = a.FechaES;
                copia.FechaFactura = a.FechaFactura;
                copia.FechaFacturaToma = a.FechaFacturaToma;
                copia.FolioFiscal = a.FolioFiscal;
                copia.GastoTotalEnCarro = a.GastoTotalEnCarro;
                copia.IdAsesorVenta = a.IdAsesorVenta;
                copia.IdBanco = a.IdBanco;
                copia.IdCarros = a.IdCarros;
                copia.IdCliente = a.IdCliente;
                copia.IdCliente = a.IdCliente;
                copia.IdEstado = a.IdEstado;
                copia.IdFormaPago = a.IdFormaPago;
                copia.Iva = a.Iva;
                copia.LeyAntilavado = a.LeyAntilavado;
                copia.MetodoPago = a.MetodoPago;
                copia.NoFacturaArv = a.NoFacturaArv;
                copia.PagadaCobrada = a.PagadaCobrada;
                copia.PrecioPactado = a.PrecioPactado;
                copia.SubTotal = a.SubTotal;
                copia.TipoVenta = a.TipoVenta;
                copia.Total = a.Total;

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Console.WriteLine("Hubo un error");
                return View(a);
            }
        }
    }
}
