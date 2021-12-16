using System;
using System.Linq;
using System.Text;

namespace BaseX.Libs
{
    public class Base16Converter : IConverter
    {
        private static readonly char[] _characterSet = "0123456789ABCDEF".ToCharArray();

        public byte[] Decode(string input)
        {
            if (string.IsNullOrEmpty(input)) return new byte[0];
            if (input.Length % 2 > 0)
                throw new ArgumentException(nameof(input));

            //[0,9] [A,F]
            //[48, 57], [65, 70]
            byte[] result = new byte[input.Length / 2];
            for (var i = 0; i < result.Length; i += 1)
            {
                int mark = 0;
                result[i] = 0;

            ENTRANCE:

                int valC = input[2 * i + mark];

                if (valC > 47 && valC < 58)
                    valC -= 48;
                else if (valC > 64 && valC < 71)
                    valC -= 55;
                else
                    throw new ArgumentException(nameof(input));

                result[i] = (byte)((result[i] << 4) | (byte)valC);

                if (mark == 0)
                {
                    mark = 1;
                    goto ENTRANCE;
                }
            }
            return result;
        }

        public string Encode(byte[] bytes)
        {
            var sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            {
                sb.Append(_characterSet[b >> 4]);
                sb.Append(_characterSet[b & 0xF]);
            }
            return sb.ToString();
        }

    }
}
