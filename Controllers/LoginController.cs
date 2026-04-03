using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_Web_VLR.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
          public ActionResult Logout()
          {
              Session.Clear();
              Session.Abandon();

              return Redirect("/Login.aspx");


      } //Este codigo me da problemas, creo que las vistas no se conectan con el login de google forms//


    }
}

