using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{
    public readonly partial struct 布尔 : IComparable, IComparable<布尔>, IEquatable<布尔>
    {
        private static readonly 布尔 _真 = true;
        public static 布尔 真 { get { return _真; } }

        private static readonly 布尔 _假 = false;
        public static 布尔 假 { get { return _假; } }

        private readonly bool _值;

        internal 布尔(bool 值)
        {
            _值 = 值;
        }

        public int CompareTo(布尔 other)
        {
            return _值.CompareTo(other._值);
        }

        public int CompareTo(object obj)
        {
            return _值.CompareTo(obj);
        }

        public bool Equals(布尔 other)
        {
            return _值.Equals(other._值);
        }

        public TypeCode GetTypeCode()
        {
            return _值.GetTypeCode();
        }
    }

    public readonly partial struct 布尔
    {
        public static implicit operator 布尔(bool 值)
        {
            return new 布尔(值);
        }

        public static implicit operator bool(布尔 值)
        {
            return 值._值;
        }

        public static 布尔 operator &(布尔 值1, 布尔 值2)
        {
            return new 布尔(值1._值 & 值2._值);
        }
        public static 布尔 operator |(布尔 值1, 布尔 值2)
        {
            return new 布尔(值1._值 | 值2._值);
        }
        public static 布尔 operator ^(布尔 值1, 布尔 值2)
        {
            return new 布尔(值1._值 ^ 值2._值);
        }
        public static 布尔 operator !(布尔 值)
        {
            return new 布尔(!值._值);
        }
    }


}
