using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP229_Lesson8.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "This is store index";
            return View();
        }

        // GET: /Store/Browse?genre=Rock
        public ActionResult Browse(string genre)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return View();
        }

        // GET: /Store/Details/3
        public ActionResult Details(int id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Details, ID =" + id);
            return View();
        }
    }
}