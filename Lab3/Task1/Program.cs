using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        Euclidean euclideanAlgorithm = new Euclidean();
        int[]? numbers = Array.Empty<int>();

        Console.WriteLine("Enter more than 2 numbers: A B C...");
        try
        {
            numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToArray();
            if (numbers.Length < 2) throw new Exception();
            foreach (int number in numbers)
            {
                if (number < 0) throw new Exception();
            }
        }
        catch
        {
            Console.WriteLine("Wrong format");
        }

        if (numbers.Length == 2)
        {
            TimeSpan ts = new TimeSpan();

            int res = euclideanAlgorithm.MeasureTimeGCD(numbers[0], numbers[1], out ts);
            Console.WriteLine($"GCD result: {res}, time spent: {ts.Milliseconds} ms");

            res = euclideanAlgorithm.MeasureTimeBinaryGCD(numbers[0], numbers[1], out ts);
            Console.WriteLine($"Binary GCD result: {res}, time spent: {ts.Milliseconds} ms");
        }

        if (numbers.Length > 2)
        {
            int res = euclideanAlgorithm.GetGCDMultiple(values: numbers);
            Console.WriteLine($"GCD Multiple result: {res}");
        }
    }
}