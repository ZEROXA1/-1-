using System;

namespace LIB
{
    public static class MathString
    {
       
        public static double[] Array(int count, int min = -5, int max = 4)
        {
            double[] array = new double[count];
            Random rnd = new();
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(min, max);
            }
            return array;
        }

       
        public static void SignSquare(this double[] array, out string resSqrt, out string resPow)
        {
            resSqrt = String.Empty;
            resPow = String.Empty;
            double sqrt = 0;
            double pow = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sqrt = Math.Round(Math.Sqrt(array[i]), 2);
                    resSqrt += sqrt + "\r\n";
                }
                else if (array[i] < 0)
                {
                    pow = Math.Pow(array[i], 2);
                    resPow += pow + "\r\n";
                }
            }
        }
    }
}
