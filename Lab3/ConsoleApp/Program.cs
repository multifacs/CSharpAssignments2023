using Euclidean;

Console.WriteLine("Enter num of values: 2, 3, 4, 5");
int num = int.Parse(Console.ReadLine());

EuclideanAlgorithm euclideanAlgorithm = new EuclideanAlgorithm();

switch (num)
{
    case 2:
        Console.WriteLine("Enter A B:");
        var numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();
        TimeSpan ts = new TimeSpan();

        int res = euclideanAlgorithm.MeasureTimeGCD(numbers[0], numbers[1], ref ts);
        Console.WriteLine($"GCD result: {res}, time spent: {ts.Milliseconds} ms");

        res = euclideanAlgorithm.MeasureTimeBinaryGCD(numbers[0], numbers[1], ref ts);
        Console.WriteLine($"Binary GCD result: {res}, time spent: {ts.Milliseconds} ms");
        break;
    case 3:
        Console.WriteLine("Enter A B C:");
        numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();

        res = euclideanAlgorithm.GetGCD3(numbers[0], numbers[1], numbers[2]);
        Console.WriteLine($"GCD3 result: {res}");
        break;
    case 4:
        Console.WriteLine("Enter A B C D:");
        numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();

        res = euclideanAlgorithm.GetGCD4(numbers[0], numbers[1], numbers[2], numbers[3]);
        Console.WriteLine($"GCD4 result: {res}");
        break;
    case 5:
        Console.WriteLine("Enter A B C D E:");
        numbers = Console.ReadLine()?.Split(' ')?.Select(int.Parse)?.ToList();

        res = euclideanAlgorithm.GetGCD5(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
        Console.WriteLine($"GCD5 result: {res}");
        break;
    default:
        break;
}