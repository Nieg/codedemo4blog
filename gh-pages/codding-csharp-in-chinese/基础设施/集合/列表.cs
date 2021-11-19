using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace 基础设施.集合
{
    public class 列表<T> : 集合接口<T>
    {
        private readonly List<T> _集合;

        public 列表()
        {
            _集合 = new List<T>();
        }

        public void 添加(T 元素)
        {
            _集合.Add(元素);
        }


        public int 长度()
        {
            return _集合.Count();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _集合.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_集合).GetEnumerator();
        }
    }
}
