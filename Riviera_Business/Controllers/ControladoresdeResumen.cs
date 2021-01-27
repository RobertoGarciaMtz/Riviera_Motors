﻿using Microsoft.AspNetCore.Http;
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
        // ControladoresdeResumen/Desempeno
        public ActionResult Desempeno(int id)
        {
         
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            ViewBag.seguimientos  = context.TbSeguimiento.ToList();
            var listasesor = context.CAsesores.ToList();

            int[] emptyStringArray = new int[3] ;
            emptyStringArray[0] = context.TbSeguimiento.Where(ass => ass.IdAsesor == listasesor[1].IdAsesores).Count();
            emptyStringArray[1] = context.TbSeguimiento.Where(ass => ass.IdAsesor == listasesor[2].IdAsesores).Count();
            emptyStringArray[2] = context.TbSeguimiento.Where(ass => ass.IdAsesor == listasesor[3].IdAsesores).Count();

            Array.Sort(emptyStringArray);

            ViewBag.npruebas= context.TbSeguimiento.Where(man => man.RealizoPruebaManejo == 1).Count();

            ViewBag.nanticipos = context.TbSeguimiento.Where(ant => ant.DejoApartadoEnganche == 1).Count();

            ViewBag.ncitas = context.TbSeguimiento.Where(nc => nc.AgendoCita == 1).Count();

            

            int[] mediopubli = new int[7];
            mediopubli[0] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 1).Count();
            mediopubli[1] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 2).Count();
            mediopubli[2] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 3).Count();
            mediopubli[3] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 4).Count();
            mediopubli[4] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 5).Count();
            mediopubli[5] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 6).Count();
            mediopubli[6] = context.TbSeguimiento.Where(mpp => mpp.IdMedioPublicitario == 7).Count();


            Console.WriteLine(""+emptyStringArray[0]);
            Console.WriteLine(""+emptyStringArray[1]);
            Console.WriteLine(""+emptyStringArray[2]);
            Console.WriteLine();

            //Llenar los suficientes campos
            //Imprimir en consola que te devuelva bien los valores
            //Guardar en ViewBag cada variable
            //Manipula los datos desde la vista
            //en la vista ViewBag.pruebas
            return View();
        }




        [HttpGet]
        public float Utilidades(int id) {

            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            var carros = context.TbCarros.ToList();
            foreach (var carro in carros)
            {
                ViewBag.gastos = context.TbGastos.Where(gas => gas.IdCarro == carro.IdCarros).Select(x => x.Monto).Sum();
                ViewBag.gasto_compra = context.TbControl.Where(tc => tc.IdCarros == carro.IdCarros && tc.CompraVenta == 1).Select(x => x.PrecioPactado);
                ViewBag.ganancia = context.TbControl.Where(tc => tc.IdCarros == carro.IdCarros && tc.CompraVenta == 2).Select(x => x.PrecioPactado).Sum();
                //var utilidad = ganancia - (gasto_compra + gastos.Value);
            }
            var total = 0;
            //utilidad en interagencias

            //utilidad en interagencias

            //utilidad en exportacion 
            return total;
        }

        [HttpGet]
        public int  NSeguros()
        {
            int[] infoseguros = new int[5];
            var context = HttpContext.RequestServices.GetService(typeof(riviera_businessContext)) as riviera_businessContext;
            infoseguros[0] = context.TbSeguro.Count();
            infoseguros[1] = context.TbSeguro.Where(seg=>seg.TipoPoliza==1).Count();
            infoseguros[2] = context.TbSeguro.Where(seg=> seg.TipoPoliza==2).Count();
            infoseguros[3] = context.TbSeguro.Where(seg => seg.TipoPoliza == 3).Count();
            infoseguros[4] = context.TbSeguro.Where(seg => seg.TipoPoliza == 4).Count();
             
            return infoseguros[0];
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


    }
}
