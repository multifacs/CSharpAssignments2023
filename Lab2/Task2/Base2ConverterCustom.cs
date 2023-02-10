namespace Task2
{
    public class Base2ConverterCustom
    {
        public string GetBase2(int a)
        {
            if (a < 0) return "null";

            int b, d, i;
            string c = "";
            i = 0;
            d = a;

            while (a != 0)
            {
                b = a % 2;
                a = a / 2;
                c += b;
                i++;
            }

            char[] charArray = c.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
