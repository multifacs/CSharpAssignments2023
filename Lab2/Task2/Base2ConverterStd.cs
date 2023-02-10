namespace Task2
{
    public class Base2ConverterStd
    {
        public string GetBase2(int num)
        {
            if (num < 0) return "null";
            return Convert.ToString(num, 2);
        }
    }
}
