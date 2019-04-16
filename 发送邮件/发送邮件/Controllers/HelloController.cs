using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace 发送邮件.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        public String hello()
        {

            //MailMessage mail = new MailMessage();
            //mail.To.Add("17875628610@qq.com");
            //mail.From = new MailAddress("17875628610@qq.com", "dulei", System.Text.Encoding.UTF8);
            //mail.Subject = "test";
            //mail.SubjectEncoding = Encoding.UTF8;
            //mail.Body = "test";
            //mail.BodyEncoding = Encoding.UTF8;
            //mail.IsBodyHtml = false;

            //SmtpClient smtp = new SmtpClient();



            //smtp.Host = "smtp.qq.com";

            //smtp.Port = 587;

            //smtp.EnableSsl = true;

            //NetworkCredential network = new NetworkCredential("17875628610@qq.com", "qq17875628610");

            //smtp.Send(mail);


            //使用QQ来进行发送邮箱 如果以后有钱可以考虑使用邮箱服务

            Email email = new Email();
            email.mailFrom = "17875628610@qq.com";
            email.mailPwd = "qq17875628610";
            email.mailSubject = "邮件主题";
            email.mailBody = "邮件内容";
            email.isbodyHtml = false;    //是否是HTML
            email.host = "smtp:qq.com";//如果是QQ邮箱则：smtp:qq.com,依次类推
            email.mailToArray = new string[] { "2723095144@qq.com" };//接收者邮件集合
            email.mailCcArray = new string[] { "2723095144@qq.com" };//抄送者邮件集合

            email.Send();

            return "";
        }
        

    }
}