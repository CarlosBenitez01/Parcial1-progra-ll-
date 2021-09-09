using Carlos_Francisco_Benitez_Quintanilla.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carlos_Francisco_Benitez_Quintanilla.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Retiro()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        [HttpPost]

        public ActionResult ProcVal(CajeroViewModel cajero)
        {
            if (Convert.ToInt32(cajero.Monto) % 5 == 0)
            {
                ViewBag.monto = cajero.Monto;
                return Redirect("/Cajero/Retiro");

            }
            else
            {
                return Redirect("/Cajero/Error");
            }
        }
    }
}