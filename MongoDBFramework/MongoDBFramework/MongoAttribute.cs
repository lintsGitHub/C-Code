using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBFramework
{
    /// <summary>
    /// MongoDB属性
    /// </summary>
    class MongoAttribute : Attribute
    {
        public MongoAttribute(string database, string collection)
        {
            Database = database;
            Collection = collection;
        }

        /// <summary>
        /// 数据库名称
        /// </summary>
        public string Database { get; private set; }

        /// <summary>
        /// 集合名称
        /// </summary>
        public string Collection { get; private set; }

    }
}
