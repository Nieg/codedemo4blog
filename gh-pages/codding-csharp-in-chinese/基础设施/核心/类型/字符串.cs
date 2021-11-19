using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{
    public partial class 字符串
    {
        private readonly string _值;
        internal 字符串(string 值)
        {
            _值 = 值;
        }
        public override bool Equals(object obj)
        {
            return _值.Equals(obj);
        }

        public override int GetHashCode()
        {
            return _值.GetHashCode();
        }

        public override string ToString()
        {
            return _值.ToString();
        }

    }

    public partial class 字符串
    {
        public static implicit operator 字符串(string 值)
        {
            return new 字符串(值);
        }

        public static implicit operator string(字符串 值)
        {
            return 值._值;
        }

        public static bool operator ==(字符串 值1, 字符串 值2)
        {
            return 值1._值 == 值2._值;
        }

        public static bool operator !=(字符串 值1, 字符串 值2)
        {
            return 值1._值 != 值2._值;
        }

        public static 字符串 operator +(字符串 值1, 字符串 值2)
        {
            return 值1._值 + 值2._值;
        }

    }



}
