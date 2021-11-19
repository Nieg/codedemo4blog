using System;
using System.Collections.Generic;
using System.Text;

namespace 基础设施
{
    public readonly partial struct 整型 : IComparable, IComparable<整型>, IEquatable<整型>, IFormattable
    {
        private static readonly 整型 _最大值 = int.MaxValue;
        public static 整型 最大值 { get { return _最大值; } }

        private static readonly 整型 _最小值 = int.MinValue;
        public static 整型 最小值 { get { return _最小值; } }

        internal 整型(int 值)
        {
            _值 = 值;
        }

        private readonly int _值;

        public int CompareTo(object obj)
        {
            return _值.CompareTo(obj);
        }

        public int CompareTo(整型 other)
        {
            return _值.CompareTo(other._值);
        }

        public bool Equals(整型 other)
        {
            return _值.Equals(other._值);
        }

        public string ToString(IFormatProvider provider)
        {
            return _值.ToString(provider);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _值.ToString(format, formatProvider);
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

    public readonly partial struct 整型
    {
        public static implicit operator 整型(int 值)
        {
            return new 整型(值);
        }
        public static implicit operator int(整型 值)
        {
            return 值._值;
        }

        public static bool operator >(整型 值1, 整型 值2)
        {
            return 值1._值 > 值2._值;
        }
        public static bool operator <(整型 值1, 整型 值2)
        {
            return 值1._值 < 值2._值;
        }
        public static bool operator >=(整型 值1, 整型 值2)
        {
            return 值1._值 >= 值2._值;
        }
        public static bool operator <=(整型 值1, 整型 值2)
        {
            return 值1._值 <= 值2._值;
        }
        public static bool operator ==(整型 值1, 整型 值2)
        {
            return 值1._值 == 值2._值;
        }
        public static bool operator !=(整型 值1, 整型 值2)
        {
            return 值1._值 != 值2._值;
        }


        public static 整型 operator +(整型 值1, 整型 值2)
        {
            return 值1._值 + 值2._值;
        }
        public static 整型 operator -(整型 值1, 整型 值2)
        {
            return 值1._值 - 值2._值;
        }
        public static 整型 operator *(整型 值1, 整型 值2)
        {
            return 值1._值 * 值2._值;
        }
        public static 整型 operator /(整型 值1, 整型 值2)
        {
            try
            {
                return 值1._值 / 值2._值;
            }
            catch (DivideByZeroException)
            {
                throw new 被除零异常();
            }
        }


        public static 整型 operator ++(整型 值1)
        {
            int 值 = 值1._值;
            return new 整型(++值);
        }
        public static 整型 operator --(整型 值1)
        {
            int 值 = 值1._值;
            return new 整型(--值);
        }


        public static 整型 operator &(整型 值1, 整型 值2)
        {
            return new 整型(值1._值 & 值2._值);
        }
        public static 整型 operator |(整型 值1, 整型 值2)
        {
            return new 整型(值1._值 | 值2._值);
        }
        public static 整型 operator ^(整型 值1, 整型 值2)
        {
            return new 整型(值1._值 ^ 值2._值);
        }
        public static 整型 operator ~(整型 值)
        {
            return new 整型(~值._值);
        }
    }

    public readonly partial struct 整型
    {
        public static implicit operator 长整型(整型 值)
        {
            return new 长整型(值._值);
        }

    }

}
