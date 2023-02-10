using Task1;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the n");
        int n = int.Parse(Console.ReadLine());

        double precision = 0.00001;
        Console.WriteLine($"Enter precision (or press enter for the default: {precision})");
        string enteredPrecision = Console.ReadLine();
        if (enteredPrecision != "")
        {
            precision = double.Parse(enteredPrecision);
        }

        NewtonsMethod solver = new NewtonsMethod(n, a, precision);
        Console.WriteLine($"Result: {solver.Calculate()}");
    }
}