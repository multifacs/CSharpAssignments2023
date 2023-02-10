using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        while ((userInput = Console.ReadLine()) != null && userInput != "")
        {
            string[]? stringArray;
            try
            {
                stringArray = userInput.Split(",");
            }
            catch
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            decimal? x;
            decimal? y;
            try
            {
                x = decimal.Parse(stringArray[0], CultureInfo.InvariantCulture);
                y = decimal.Parse(stringArray[1], CultureInfo.InvariantCulture);
            }
            catch
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            Console.WriteLine($"X: {x} Y: {y}");
        }
    }
}