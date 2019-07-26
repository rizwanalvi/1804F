using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webmvc02.Models;
namespace Webmvc02.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Mobile mb = new Mobile();
            ViewBag.MobileData = mb.GetAllMobile();
            return View();
        }
        [HttpGet]
        public ActionResult ContactUs()
        {
            return View();
        }
        public ActionResult Career()
        {
            return View();
        }
        public ActionResult Show(int id) {
            Mobile mb = new Mobile();
            List<Mobile> lstmb = mb.GetAllMobile();
           var mb1=   lstmb.Where(x => x.MobileId == id).SingleOrDefault();
            ViewBag.MbData = mb1;
            return View();
        }









        public ActionResult AddData()
        {


            return View();
        }

        [HttpPost]
        public ActionResult AddData(Mobile mb) {


            return View();
        }
      
    }
}