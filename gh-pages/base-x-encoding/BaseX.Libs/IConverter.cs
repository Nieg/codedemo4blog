using System;
using System.Collections.Generic;
using System.Text;

namespace BaseX.Libs
{
    internal interface IConverter
    {
        public string Encode(byte[] bytes);

        public byte[] Decode(string input);

    }
}
