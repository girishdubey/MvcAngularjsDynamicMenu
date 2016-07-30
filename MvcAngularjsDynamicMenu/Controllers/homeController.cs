using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAngularjsDynamicMenu.Controllers
{
    public class homeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetSiteMenu()
        {
            using (MenuDatabaseEntities md = new MenuDatabaseEntities())
            {
                var data = md.Tab_Menu.ToList();
                return new JsonResult { Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

    }
}
