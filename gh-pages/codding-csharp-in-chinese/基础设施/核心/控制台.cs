using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{

    public static class 控制台
    {
        public static 字符串 读取字符串()
        {
            return Console.ReadLine();
        }

        public static 字符 读取字符()
        {
            return Console.ReadKey().KeyChar;
        }

        public static void 输出字符串(字符串 格式, params object[] 参数)
        {
            Console.WriteLine(格式, 参数);
        }
        public static void 输出字符串<T>(T 参数)
        {
            Console.WriteLine(参数);
        }

    }
}
