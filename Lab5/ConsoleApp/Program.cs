using Lab5;

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
                Console.WriteLine("Enter A B for polynomial A");
                var numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();
                polynomialA = new(numbers[0], numbers[1]);

                Console.WriteLine("Enter A B for polynomial A");
                numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();
                polynomialB = new(numbers[0], numbers[1]);
            }

            if (polynomialA != null && polynomialB != null)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("PrintA PrintB Add Subtract New Exit");

                userInput = Console.ReadLine();

                if (userInput == "PrintA")
                {
                    Console.WriteLine($"({polynomialA})");
                }

                if (userInput == "PrintB")
                {
                    Console.WriteLine($"({polynomialB})");
                }

                if (userInput == "Add")
                {
                    Console.WriteLine($"({polynomialA}) + ({polynomialB}) =");
                    Console.WriteLine($"({polynomialA + polynomialB})");
                }

                if (userInput == "Subtract")
                {
                    Console.WriteLine($"({polynomialA}) - ({polynomialB}) =");
                    Console.WriteLine($"({polynomialA - polynomialB})");
                }

                if (userInput == "New")
                {
                    polynomialA = null;
                    polynomialB = null;
                }
            }
        }
    }
}