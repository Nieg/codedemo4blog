
using 基础设施;

namespace 入口程序.公共代码
{
    public class 登录信息
    {
        public 字符串 姓名 { get; set; }

        public 布尔 是有效用户 { get; set; }

        public 整型 总工作年限 { get; set; }

        public 整型 总获奖次数 { get; set; }

        public override string ToString()
        {
            return $"姓名[{姓名}],有效[{是有效用户}],工作年限[{总工作年限}],获奖次数[{总获奖次数}]";
        }
    }
}
