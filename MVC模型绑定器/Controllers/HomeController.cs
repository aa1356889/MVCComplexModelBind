using MVC模型绑定器.Bind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC模型绑定器.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// A
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public ActionResult ABind([ModelBinder(typeof(MyArrayBind))]Classes classes)
        {
            return Json(classes);
        }


        /// <summary>
        /// B
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public ActionResult BBind([ModelBinder(typeof(MyArrayBind))]Classes[] classes)
        {
            return Json(classes);
        }


        /// <summary>
        /// C
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public ActionResult CBind([ModelBinder(typeof(MyArrayBind))]Classes classes)
        {
            return Json(classes);
        }


        
    }
}
