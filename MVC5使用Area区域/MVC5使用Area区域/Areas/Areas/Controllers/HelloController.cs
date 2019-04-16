using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MVC5使用Area区域.Areas.Areas.Controllers
{
    public class HelloController : Controller
    {
        // GET: Areas/Hello
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]  //这个注解就是Hello方法只是接收Post请求
        public String Hello() {
           ArrayList list = new ArrayList();
            list.Add("hello");
            list.Add("hello");
            list.Add("hello");
            list.Add("hello");
            list.Add("hello");
            list.Add("hello");
            return JsonConvert.SerializeObject(list);
        }
    }
}