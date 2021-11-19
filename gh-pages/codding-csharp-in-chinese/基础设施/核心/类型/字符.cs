using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{
    public readonly partial struct 字符 : IComparable, IComparable<字符>, IEquatable<字符>
    {
        private static readonly 字符 _最大值 = char.MaxValue;
        public static 字符 最大值 { get { return _最大值; } }

        private static readonly 字符 _最小值 = char.MinValue;
        public static 字符 最小值 { get { return _最小值; } }

        internal 字符(char 值)
        {
            _值 = 值;
        }

        private readonly char _值;

        public int CompareTo(object obj)
        {
            return _值.CompareTo(obj);
        }

        public int CompareTo(字符 other)
        {
            return _值.CompareTo(other._值);
        }

        public bool Equals(字符 other)
        {
            return _值.Equals(other._值);
        }

        public string ToString(IFormatProvider provider)
        {
            return _值.ToString(provider);
        }

        public override bool Equals(object obj)
        {
            return _值.Equals(obj);
        }

        public override int GetHashCode()
        {
            return _值.GetHashCode();
        }

    }

    public readonly partial struct 字符
    {

        public static implicit operator 字符(char 值)
        {
            return new 字符(值);
        }

        public static implicit operator char(字符 值)
        {
            return 值._值;
        }

        public static explicit operator 字符(整型 值)
        {
            return new 字符((char)(int)值);
        }

        public static explicit operator 整型(字符 值)
        {
            return 值._值;
        }

    }
}
