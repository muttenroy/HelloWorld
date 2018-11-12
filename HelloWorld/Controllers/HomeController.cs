using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Sumar(1, 2);

            ViewBag.Message = "This is my first MVC 5 App. " + resultado.ToString(); 
            return View();
        }

    }
    public class Calculadora

    {

        public int Sumar(int num1, int num2)

        {

            return num1 + num2;

        }

    }
}