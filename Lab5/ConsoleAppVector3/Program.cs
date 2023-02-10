using Lab5;

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
                Console.WriteLine("Enter X Y Z for vector A");
                var numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();
                vectorA = new(numbers[0], numbers[1], numbers[2]);

                Console.WriteLine("Enter X Y Z for vector B");
                numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();
                vectorB = new(numbers[0], numbers[1], numbers[2]);
            }

            if (vectorA != null && vectorB != null)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("PrintA PrintB Add Subtract Multiply New Exit");

                userInput = Console.ReadLine();

                if (userInput == "PrintA")
                {
                    Console.WriteLine($"({vectorA})");
                }

                if (userInput == "PrintB")
                {
                    Console.WriteLine($"({vectorB})");
                }

                if (userInput == "Add")
                {
                    Console.WriteLine($"({vectorA}) + ({vectorB}) =");
                    Console.WriteLine($"({vectorA + vectorB})");
                }

                if (userInput == "Subtract")
                {
                    Console.WriteLine($"({vectorA}) - ({vectorB}) =");
                    Console.WriteLine($"({vectorA - vectorB})");
                }

                if (userInput == "Multiply")
                {
                    Console.WriteLine($"({vectorA}) * ({vectorB}) =");
                    Console.WriteLine($"({vectorA * vectorB})");
                }

                if (userInput == "New")
                {
                    vectorA = null;
                    vectorB = null;
                }
            }
        }
    }
}