using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        string userInput = "";
        Polynomial polynomialA = null;
        Polynomial polynomialB = null;

        while (userInput != "Exit")
        {
            if (polynomialA == null || polynomialB == null)
            {
                double[] numbers = Array.Empty<double>();
                Console.WriteLine("Enter A B for polynomial A");
                try
                {
                    numbers = Console.ReadLine()?.Split(' ')?.Select(double.Parse)?.ToArray();
                    if (numbers.Length != 2) { throw new Exception(); }
                }
                catch
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }
                polynomialA = new(numbers[0], numbers[1]);

                Console.WriteLine("Enter A B for polynomial B");
                try
                {
                    numbers = Console.ReadLine()?.Split(' ')?.Select(double.Parse)?.ToArray();
                    if (numbers.Length != 2) { throw new Exception(); }
                }
                catch
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }
                polynomialB = new(numbers[0], numbers[1]);
            }

            if (polynomialA != null && polynomialB != null)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("PrintA PrintB Add Subtract New Exit");

                userInput = Console.ReadLine();

                if (userInput == "PrintA")
                {
                    Console.WriteLine($"({polynomialA})\n");
                }

                if (userInput == "PrintB")
                {
                    Console.WriteLine($"({polynomialB})\n");
                }

                if (userInput == "Add")
                {
                    Console.WriteLine($"({polynomialA}) + ({polynomialB}) =");
                    Console.WriteLine($"({polynomialA + polynomialB})\n");
                }

                if (userInput == "Subtract")
                {
                    Console.WriteLine($"({polynomialA}) - ({polynomialB}) =");
                    Console.WriteLine($"({polynomialA - polynomialB})\n");
                }

                if (userInput == "New")
                {
                    polynomialA = null;
                    polynomialB = null;
                    Console.WriteLine();
                }
            }
        }
    }
}