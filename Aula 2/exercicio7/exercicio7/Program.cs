using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7
{
    class exercicio7
    {
        static void Main(string[] args)
        {
            sbyte sbmax = sbyte.MaxValue;
            sbyte sbmin = sbyte.MinValue;
            char cmax = char.MaxValue;
            char cmin = char.MinValue;
            short smax = short.MaxValue;
            short smin = short.MinValue;
            int imax = int.MaxValue;
            int imin = int.MinValue;
            double dmax = double.MaxValue;
            double dmin = double.MinValue;
            float fmax = float.MaxValue;
            float fmin = float.MinValue;
            ulong ulmax = ulong.MaxValue;
            ulong ulmin = ulong.MinValue;

            Console.WriteLine("Valor máximo de sbyte: " + sbmax);
            Console.WriteLine("Valor mínimo de sbyte: " + sbmin);

            Console.WriteLine("Valor máximo de char: " + cmax);
            Console.WriteLine("Valor mínimo de char: " + cmin);

            Console.WriteLine("Valor máximo de short: " + smax);
            Console.WriteLine("Valor mínimo de short: " + smin);

            Console.WriteLine("Valor máximo de int: " + imax);
            Console.WriteLine("Valor mínimo de int: " + imin);

            Console.WriteLine("Valor máximo de double: " + dmax);
            Console.WriteLine("Valor mínimo de double: " + dmin);

            Console.WriteLine("Valor máximo de float: " + fmax);
            Console.WriteLine("Valor mínimo de float: " + fmin);

            Console.WriteLine("Valor máximo de ulong: " + ulmax);
            Console.WriteLine("Valor mínimo de ulong: " + ulmin);

        }
    }
}
