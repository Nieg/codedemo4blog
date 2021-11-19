using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{
    public sealed class 判断
    {

        readonly bool _条件;

        private 判断(bool 条件)
        {
            _条件 = 条件;
        }

        public static 判断 如果是(bool 条件)
        {
            return new 判断(条件);
        }

        public 判断 则(Action action)
        {
            if (_条件) action();
            return this;
        }

        public 判断 否则(Action 否则处理程序)
        {
            if (!_条件) 否则处理程序();
            return this;
        }

        public 判断 否则如果是(bool 条件)
        {
            return new 判断(!_条件 && 条件);
        }
    }
}
