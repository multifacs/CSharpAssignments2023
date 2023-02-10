using Task1;
internal class Program
{
    private static void Main(string[] args)
    {
        string userInput = "";
        Vector3 vectorA = null;
        Vector3 vectorB = null;

        while (userInput != "Exit")
        {
            if (vectorA == null || vectorB == null)
            {
                double[] numbers = Array.Empty<double>();
                Console.WriteLine("Enter X Y Z for vector A");
                try
                {
                    numbers = Console.ReadLine()?.Split(' ')?.Select(double.Parse)?.ToArray();
                    if (numbers.Length != 3) { throw new Exception(); }
                }
                catch
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }
                vectorA = new(numbers[0], numbers[1], numbers[2]);

                Console.WriteLine("Enter X Y Z for vector B");
                try
                {
                    numbers = Console.ReadLine()?.Split(' ')?.Select(double.Parse)?.ToArray();
                    if (numbers.Length != 3) { throw new Exception(); }
                }
                catch
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }
                vectorB = new(numbers[0], numbers[1], numbers[2]);
            }

            if (vectorA != null && vectorB != null)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("PrintA PrintB Add Subtract Multiply New Exit");

                userInput = Console.ReadLine();

                if (userInput == "PrintA")
                {
                    Console.WriteLine($"({vectorA})\n");
                }

                if (userInput == "PrintB")
                {
                    Console.WriteLine($"({vectorB})\n");
                }

                if (userInput == "Add")
                {
                    Console.WriteLine($"({vectorA}) + ({vectorB}) =");
                    Console.WriteLine($"({vectorA + vectorB})\n");
                }

                if (userInput == "Subtract")
                {
                    Console.WriteLine($"({vectorA}) - ({vectorB}) =");
                    Console.WriteLine($"({vectorA - vectorB})\n");
                }

                if (userInput == "Multiply")
                {
                    Console.WriteLine($"({vectorA}) * ({vectorB}) =");
                    Console.WriteLine($"({vectorA * vectorB})\n");
                }

                if (userInput == "MultiplyByNum")
                {
                    double num = 0;
                    try
                    {
                        num = double.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Wrong format");
                    }
                    Console.WriteLine($"vectorA = ({vectorA.MultiplyByNum(num)})");
                    Console.WriteLine($"vectorB = ({vectorB.MultiplyByNum(num)})\n");
                }

                if (userInput == "New")
                {
                    vectorA = null;
                    vectorB = null;
                    Console.WriteLine();
                }
            }
        }
    }
}