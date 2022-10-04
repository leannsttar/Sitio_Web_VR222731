
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Sitio_Web_VR222731.Models;

namespace Sitio_Web_VR222731.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Dropdown categorias
            Categorias ct = new Categorias();
            Conexion obj = new Conexion();
            ct.categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            localidad loc = new localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            ViewBag.Ofertas = obj.CargarDatos();
            return View();
        }
        [HttpPost]
        public ActionResult Index(string OpcionesCat, string OpcionesLoc, string OpcionesEmp)
        {
            int dcat, dloc, demp;
            dcat = Convert.ToInt16(OpcionesCat);
            dloc = Convert.ToInt16(OpcionesLoc);
            demp = Convert.ToInt16(OpcionesEmp);
            //Dropdown categorias
            Categorias ct = new Categorias();
            Conexion obj = new Conexion();
            ct.categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            localidad loc = new localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            ViewBag.Ofertas = obj.CargarDatos(dcat, dloc, demp);
            return View();
        }
    }
}