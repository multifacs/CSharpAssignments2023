using System.Diagnostics;

namespace Task1
{
    public class Euclidean
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

        public int GetGCDMultiple(params int[] values)
        {
            if (values.Length == 2)
            {
                return GetGCD(values[0], values[1]);
            }
            if (values.Length > 2)
            {
                int tempRes = GetGCD(values[values.Length - 2], values[values.Length - 1]);
                int[] newValues = values.Take(values.Length - 2).ToArray();
                newValues = newValues.Append(tempRes).ToArray();
                return GetGCDMultiple(values: newValues);
            }
            return -1;
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

        public int MeasureTimeGCD(int value1, int value2, out TimeSpan ts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = GetGCD(value1, value2);
            stopWatch.Stop();

            ts = stopWatch.Elapsed;
            return res;
        }

        public int MeasureTimeBinaryGCD(int value1, int value2, out TimeSpan ts)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int res = GetBinaryGCD(a: value1, b: value2);
            stopWatch.Stop();

            ts = stopWatch.Elapsed;
            return res;
        }
    }
}
