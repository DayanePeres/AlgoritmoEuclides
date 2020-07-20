using System;

namespace AlgoritmoEuclides
{
    class Program
    {
        //Algoritmo de Euclides iterativo para calcular MDC
        public static int mdc(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        //Calcula o MDC de uma lista de números
        public static int mdcLista(int[] numberList)
        {
            if (numberList.Length < 2)
            {
                throw new Exception("A lista deve conter pelo menos dois números");
            }
            int mdcResultado = numberList[0];
            for (int i = 1; i < numberList.Length; i++)
            {
                mdcResultado = mdc(mdcResultado, numberList[i]);
            }
            return mdcResultado;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("MDC(2,3,4,5) = " + mdcLista(new int[] { 2, 3, 4, 5 }));
            //Console.WriteLine("MDC(1024, 4, 24, 12) = " + mdcLista(new int[] { 1024, 4, 24, 12 }));
            //Console.WriteLine("MDC(49, 14, 77, 63) = " + mdcLista(new int[] { 49, 14, 77, 63 }));
            //Console.WriteLine("MDC(100, 20) = " + mdcLista(new int[] { 100, 20 }));
            Console.WriteLine("MDC(100, 20) = " + mdcLista(new int[] { 42, 70 }));
        }
    }
}
