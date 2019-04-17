using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using Newtonsoft.Json;

namespace 使用MongoDB.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public String getMongoDBData() {
            //连接信息


            //连接字符串
            string conn = "mongodb://172.16.21.229:27018";

            //数据库名
            string database = "FightNews";

            //集合名
            string collection = "obj";

            //建立连接
            MongoClient client = new MongoClient(conn);

            //获取数据库
            IMongoDatabase data = client.GetDatabase(database);
            //获取集合
            var collections = data.GetCollection<BsonDocument>(collection);

            //获取前20条
           var docm = collections.Find(new BsonDocument()).Limit(20);

           var doms = docm.FirstOrDefault();

            return JsonConvert.SerializeObject(docm);
        }

    }
}