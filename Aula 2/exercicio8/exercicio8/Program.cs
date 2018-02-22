using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class exercicio8
    {
        static void Main(string[] args)
        {
            sbyte sb = sbyte.MaxValue;
            sbyte sbof = (sbyte)(sb + 1);
            byte b = byte.MaxValue;
            byte bof = (byte)(b + 1);
            char c = char.MaxValue;
            char cof = (char)(c + 1);
            short s = short.MaxValue;
            short sof = (short)(s + 1);
            ushort us = ushort.MaxValue;
            ushort usof = (ushort)(us + 1);
            int i = int.MaxValue;
            int iof = i + 1;
            uint ui = uint.MaxValue;
            uint uiof = ui + 1;
            long l = long.MaxValue;
            long lof = l + 1;
            ulong ul = ulong.MaxValue;
            ulong ulof = ul + 1;

            Console.WriteLine("Overflow em sbyte: " + sbof);
            Console.WriteLine("Overflow em byte: " + bof);
            Console.WriteLine("Overflow em char: " + cof);
            Console.WriteLine("Overflow em short: " + sbof);
            Console.WriteLine("Overflow em ushort: " + usof);
            Console.WriteLine("Overflow em int: " + iof);
            Console.WriteLine("Overflow em uint: " + uiof);
            Console.WriteLine("Overflow em long: " + lof);
            Console.WriteLine("Overflow em ulong: " + ulof);
        }
    }
}
