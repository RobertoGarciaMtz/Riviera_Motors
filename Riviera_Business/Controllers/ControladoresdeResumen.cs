using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Riviera_Business.Models;

namespace Riviera_Business.Controllers
{
    public class ControladoresdeResumen : Controller
    {

        public ActionResult Desempeno()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbSeguimiento.ToList();
            var listasesor = context.CAsesores.ToList();
            foreach (TbSeguimiento ti in list)
            {
               var asesor1 = context.TbSeguimiento.Where(ass => ass.IdAsesor == listasesor[1].IdAsesores).Count();
                var asesor2 = context.TbSeguimiento.Where(ass => ass.IdAsesor == listasesor[2].IdAsesores).Count();
                var asesor3 = context.TbSeguimiento.Where(ass => ass.IdAsesor == listasesor[3].IdAsesores).Count();

            }
            return View(list);
        }
        // GET: HomeController1
        public ActionResult Desempeno1()
        {
            //los necesarios
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var list = context.TbSeguimiento.ToList();
            var list2 = context.CAsesores.ToList();
            var list3 = context.TbControl.ToList();
            var list4 = context.TbPapelesCarro.ToList();
            //para contar de los asesores
            int mascitas = context.TbSeguimiento.Where(seg => seg.IdAsesor == 1).Count();
            int mascitas2 = context.TbSeguimiento.Where(seg => seg.IdAsesor == 2).Count();
            int mascitas3 = context.TbSeguimiento.Where(seg => seg.IdAsesor == 3).Count();
            int mascitas4 = context.TbSeguimiento.Where(seg => seg.IdAsesor == 4).Count();
            //los demas parametros 
            int tventa = context.TbSeguimiento.Where(seg => seg.Venta == 1).Count();
            int valor = context.TbSeguimiento.Where(seg => seg.Cita == 1).Count();
            int valor2 = context.TbSeguimiento.Where(seg => seg.Anticipo == 1).Count();
            int valor3 = context.TbSeguimiento.Where(seg => seg.PruebaManejo == 1).Count();
            ///// se va a separar
            int[] redsocial = { };
            int c = 0;
            List<CMedioPublicitario> medios = new List<CMedioPublicitario>();
            foreach(CMedioPublicitario ti in medios)
            {
                redsocial[c] = context.TbSeguimiento.Where(s=>s.CMedioPublicitario==ti.IdMedioPublicitario).Count();
                    c++;
            }
            return View();
        }
        [HttpGet]
        public int mayorcitas()
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            int val=context.TbSeguimiento.Where(seg=>seg.IdAsesor==1).Count();
            return val;
        }
        /// <summary>
        /// ////////////
        // GET: HomeController1/Create
        [HttpGet]
        public  List<CuentasPendientesCP> CuentasCPO( DateTime empieza,DateTime termina)
        {
            int i = 0;
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List <CuentasPendientesCP> cuentas = context.CuentasPendientesCP.Where(cp=>cp.Fecha >=empieza).ToList();
            foreach (CuentasPendientesCP cu in cuentas)
            {
                if (cuentas[i].Fecha<=termina)
                {
                    var cuentaspagar =cuentas.Where(cue=>cue.CuentasCobrarPagarOtras==1).ToList();
                    var cuentasdebiendo = cuentas.Where(cud=>cud.CuentasCobrarPagarOtras==2).ToList();
                    var otrascuentaspa= cuentas.Where(otcpa=>otcpa.CuentasCobrarPagarOtras==3).ToList();
                    var otrascuentasco = cuentas.Where(otcco => otcco.CuentasCobrarPagarOtras==4).ToList();
                    return cuentaspagar;
                }
                i++;
            }
            return cuentas;
        }
        /// <summary>
        /// ///////////////
        /// </summary>
        // POST: HomeController1/Create
        [HttpGet]
        public String Elmas(int opcion)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            string elmas = null;
            if (opcion == 1)///el auto mas vendido
            {
                var versiones = context.CVersionCarro.Where(ver => ver.IdVersionCarro >= 0).ToList();
                var control = context.TbControl.Where(cont => cont.CompraVenta == 2 ).ToList();

            }
            if(opcion == 2)//el color mas vendido 
            {
                int[] colores= { };
                colores[0] = context.TbCarros.Where(car => car.ColorExt == "Rojo").Count();
                colores[1] = context.TbCarros.Where(car => car.ColorExt == "Azul").Count();
                colores[2] = context.TbCarros.Where(car => car.ColorExt == "Amarillo").Count();
                colores[3] = context.TbCarros.Where(car => car.ColorExt == "Blanco").Count();
                colores[4] = context.TbCarros.Where(car => car.ColorExt == "Negro").Count();
                colores[5] = context.TbCarros.Where(car => car.ColorExt == "Plata").Count();
                colores[6] = context.TbCarros.Where(car => car.ColorExt == "Gris").Count();
                colores[7] = context.TbCarros.Where(car => car.ColorExt == "Naranja").Count();
                colores[8] = context.TbCarros.Where(car => car.ColorExt == "Verde").Count();
                colores[9] = context.TbCarros.Where(car => car.ColorExt == "Violeta").Count();
                colores[10] = context.TbCarros.Where(car => car.ColorExt == "Cafe").Count();

            }
            if(opcion == 3)//mejor proveedor
            {
                int[] contenedor = new int[0];
                int[] provedor1 = new int[0];
                int i = 0, j,gu;
                List<TbCarros> mejorprov = context.TbCarros.Where(car => car.IdProveedor != null).ToList();
                foreach(TbCarros c in mejorprov)
                {
                    contenedor[i]= (int)mejorprov[i].IdProveedor;
                    i++;
                }
                 gu=contenedor[0];
                for (i = 1; i < contenedor.Length; ++i)
                {
                    if (gu < contenedor[i])
                        gu = contenedor[i];
                }
                for (i = 0; i < contenedor.Length; i++) {
                    for (j = 0; j < contenedor.Length; j++) { 
                        {
                        if (gu == contenedor[j])
                            provedor1[i]++;
                        }
                    }
                    gu -= 1;
                }
            }
            if (opcion == 4)//la marca mas vendida
            {

            }

                return elmas;
        }

        // GET: HomeController1/Edit/5
        public ActionResult Datos_propios_carros(int id)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var seguimiento = context.TbSeguimiento.ToList();
            var gastoscarr = context.TbCarros.ToList();
            var extracarr = context.CCarroExtra.ToList();
            var control = context.TbControl.ToList();
            var carr = context.TbCarros.ToList();
            var papelescarr = context.TbPapelesCarro.ToList();
            var proveedor = context.TbProveedor.ToList();
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public List<TbControl> Utilidad_Departamento(int opcion, DateTime inicio, DateTime final)
        {
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            List<TbControl> utilidad = context.TbControl.Where(ct=>ct.FechaFactura >= inicio).ToList();
            foreach (TbControl cu in utilidad)
            {
                if (cu.CompraVenta == 2) { 
                if(opcion ==1)
                    {
                        var Retail= utilidad.Where(util=>util.TipoVenta==1);
                    }
                if (opcion == 2)
                    {
                        var Interagencias = utilidad.Where(util => util.TipoVenta == 2);
                    }
                if(opcion == 3)
                    {
                        var Exportacion = utilidad.Where(util => util.TipoVenta == 3);
                    }
                }
            }
            return utilidad;
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
