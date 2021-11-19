using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace 基础设施.数据
{
    public class 数据库连接对象
    {
        private string _服务器名;
        private string _用户名;
        private string _密码;
        private string _数据库名;

        private IDbConnection _数据库连接;

        internal 数据库连接对象(string 服务器名)
        {
            _服务器名 = 服务器名;
        }

        public static 数据库连接对象 连接到(string 服务器名)
        {
            return new 数据库连接对象(服务器名);
        }

        public 数据库连接对象 用户为(string 用户名)
        {
            _用户名 = 用户名;
            return this;
        }

        public 数据库连接对象 密码为(string 密码)
        {
            _密码 = 密码;
            return this;
        }

        public 数据库连接对象 数据库为(string 数据库名)
        {
            _数据库名 = 数据库名;
            return this;
        }

        public void 打开连接()
        {
            _数据库连接 = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", _服务器名, _数据库名, _用户名, _密码));
            _数据库连接.Open();
        }

        public void 关闭连接()
        {
            _数据库连接.Close();
        }
    }
}
