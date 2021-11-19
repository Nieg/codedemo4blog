using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 基础设施.查询
{

    public class 遍历器<T>
    {
        protected IEnumerable<T> _集合;
        protected int _起始编号;
        protected int _步数;
        protected int _步长;

        public 遍历器(IEnumerable<T> 枚举集合)
        {
            _集合 = 枚举集合;
        }

        public static 遍历器<T> 计数遍历(IEnumerable<T> 枚举集合)
        {
            return new 遍历器<T>(枚举集合);
        }

        public 遍历器<T> 从(int 开始元素序号)
        {
            _起始编号 = 开始元素序号;
            return this;
        }

        public 遍历器<T> 到(int 总步数)
        {
            _步数 = 总步数;
            return this;
        }

        public 遍历器<T> 每隔(int 步长)
        {
            _步长 = 步长;
            return this;
        }

        public void 执行(Action<int, T> 循环体方法)
        {
            int 编号 = 0;
            foreach (var 元素 in _集合.Skip(_起始编号))
            {
                if (编号 >= _起始编号 && 编号 <= _步数)
                {
                    if ((编号 - _起始编号) % _步长 == 0)
                    {
                        循环体方法(编号, 元素);
                    }
                }
                编号++;
            }
        }
    }
}
