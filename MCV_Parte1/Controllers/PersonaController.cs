using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCV_Parte1.Models;

namespace MCV_Parte1.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            ClsPersona obj = new ClsPersona();
            obj.edad = 26;
            obj.nombre = "Andree";
            obj.apellido = "Velasco";
            return View(obj);
        }  
    }
}