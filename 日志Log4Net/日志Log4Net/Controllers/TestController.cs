using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace 日志Log4Net.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public String hello() {
            Log log = LogFactory.GetLogger("InfoLog");
            log.Info("Hello");
            return "";
        }
    }
}