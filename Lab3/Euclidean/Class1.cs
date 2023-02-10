using System.Diagnostics;
using System.Reflection;

namespace Euclidean
{
    public class EuclideanAlgorithm
    {
        public int GetGCD(int value1, int value2)
        {
            while (value1 != 0 && value2 != 0)
            {
                if (value1 > value2)
                    value1 %= value2;
                else
                    value2 %= value1;
            }
            return Math.Max(value1, value2);
        }

        public int GetGCD3(int value1, int value2, int value3)
        {
            int res1 = GetGCD(value2, value3);
            return GetGCD(res1, value1);
        }

        public int GetGCD4(int value1, int value2, int value3, int value4)
        {
            int res1 = GetGCD(value3, value4);
            int res2 = GetGCD(res1, value2);
            return GetGCD(res2, value1);
        }

        public int GetGCD5(int value1, int value2, int value3, int value4, int value5)
        {
            int res1 = GetGCD(value4, value5);
            int res2 = GetGCD(res1, value3);
            int res3 = GetGCD(res2, value2);
            return GetGCD(res3, value1);
        }

        public int GetBinaryGCD(int a, int b)
        {
            if (a == 0)
                return b;
            if (b == 0)
                return a;

            int k;
            for (k = 0; ((a | b) & 1) == 0; ++k)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
                a >>= 1;

            do
            {
                while ((b & 1) == 0)
                    b >>= 1;

                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                b = (b - a);
            } while (b != 0);

            return a << k;
        }

        public int MeasureTimeGCD(int value1, int value2, ref TimeSpan ts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = GetGCD(value1, value2);
            stopWatch.Stop();
            
            ts = stopWatch.Elapsed;
            return res;
        }

        public int MeasureTimeBinaryGCD(int value1, int value2, ref TimeSpan ts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = GetBinaryGCD(value1, value2);
            stopWatch.Stop();

            ts = stopWatch.Elapsed;
            return res;
        }
    }
}