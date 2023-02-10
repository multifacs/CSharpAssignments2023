using Task1;

enum Command
{
    Check = 1,
    Perimeter,
    Area,
    New,
    Exit
}

internal class Program
{
    private static void Main(string[] args)
    {
        Command userInput = Command.Check;
        Triangle triangle = null;

        while (userInput != Command.Exit)
        {
            if (triangle == null)
            {
                Console.WriteLine("Enter sides A B C");
                double[] numbers = Array.Empty<double>();

                try
                {
                    numbers = Console.ReadLine()?.Split(' ')?.Select(double.Parse)?.ToArray();
                }
                catch
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }

                triangle = new Triangle(numbers[0], numbers[1], numbers[2]);
                Console.WriteLine("Triangle created\n");
            }
            if (triangle != null)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("1: Check, 2: Perimeter, 3: Area, 4: New, 5: Exit");

                try
                {
                    userInput = (Command)int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong format");
                    continue;
                }

                switch(userInput)
                {
                    case Command.Check:
                        if (triangle.DoesExist()) { Console.WriteLine("Triangle exists\n"); }
                        else { Console.WriteLine("Triangle doesn't exist\n"); };
                        break;
                    case Command.Perimeter:
                        if (triangle.DoesExist()) { Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}\n"); }
                        else { Console.WriteLine("Triangle doesn't exist\n"); };
                        break;
                    case Command.Area:
                        if (triangle.DoesExist()) { Console.WriteLine($"Area: {triangle.GetArea()}\n"); }
                        else { Console.WriteLine("Triangle doesn't exist\n"); };
                        break;
                    case Command.New:
                        triangle = null;
                        Console.WriteLine();
                        break;
                    case Command.Exit:
                        break;
                }
            }
        }
    }
}