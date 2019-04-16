using log4net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace 日志Log4Net.Controllers
{
    public class LogFactory
    {
        //去配置文件中加载Log4Net的配置
        static LogFactory() {
            FileInfo configFile = new FileInfo(HttpContext.Current.Server.MapPath("/Configs/log4net.config"));
            log4net.Config.XmlConfigurator.Configure(configFile);
        }

        public static Log GetLogger(Type type)
        {
            return new Log(LogManager.GetLogger(type));
        }
        public static Log GetLogger(string str)
        {
            return new Log(LogManager.GetLogger(str));
        }
    }
}