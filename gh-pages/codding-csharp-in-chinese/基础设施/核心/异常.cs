using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{
    public sealed class 异常
    {
        private Exception _异常;

        private 异常(Exception 异常)
        {
            _异常 = 异常;
        }

        public static 异常 对以下语句进行异常检测(Action 执行程序)
        {
            Exception 异常 = null;
            try
            {
                执行程序();
            }
            catch (Exception ex)
            {
                异常 = ex;
            }

            return new 异常(异常);

        }

        public 异常 发现异常则(Action 异常处理程序)
        {
            if (_异常 != null && _异常 is Exception)
            {
                异常处理程序();
                _异常 = null;
            }
            return this;
        }

        public 异常 发现异常则<TEx>(Action 异常处理程序)
            where TEx : Exception
        {
            if (_异常 != null && _异常 is TEx) 异常处理程序();
            return this;
        }

        public 异常 发现异常则(Action<Exception> 异常处理程序)
        {
            if (_异常 != null && _异常 is Exception)
            {
                异常处理程序(_异常);
                _异常 = null;
            }
            return this;
        }

        public 异常 发现异常则<TEx>(Action<TEx> 异常处理程序)
            where TEx : Exception
        {
            if (_异常 != null && _异常 is TEx ex) 异常处理程序(ex);
            return this;
        }

        public void 最终执行(Action 最终执行程序)
        {
            最终执行程序();
        }
    }
}
