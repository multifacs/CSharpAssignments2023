using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter num:");
        int num = int.Parse(Console.ReadLine());

        Base2ConverterStd converterStd = new Base2ConverterStd();
        Base2ConverterCustom converterCustom = new Base2ConverterCustom();

        Console.WriteLine("STD converter: " + converterStd.GetBase2(num));
        Console.WriteLine("My converter:  " + converterCustom.GetBase2(num));
    }
}
