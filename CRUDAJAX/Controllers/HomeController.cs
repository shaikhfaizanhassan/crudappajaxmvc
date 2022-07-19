using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDAJAX.Models;
namespace CRUDAJAX.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDB empdb = new EmployeeDB();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            return Json(empdb.listAll(), JsonRequestBehavior.AllowGet);

                
        }
    }
}