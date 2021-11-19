using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施.集合
{
    public interface 集合接口<T> : IEnumerable<T>
    {
        int 长度();

    }
}
