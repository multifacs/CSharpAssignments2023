using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        int StatusBarValue = 0;

        using (StreamWithPercentage str = new StreamWithPercentage(new FileStream(
            "sample-2mb-text-file.txt",
            FileMode.Open,
            FileAccess.Read
            )))
        {
            byte[] bytes = new byte[str.Length];
            int numBytesToRead = (int)str.Length;
            int numBytesRead = 0;
            int count = numBytesToRead / 4; // divide into parts for demonstration
            while (numBytesToRead > 0)
            {
                if (count > numBytesToRead) { count = numBytesToRead; }
                int n = str.Read(bytes, numBytesRead, count);

                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;

                StatusBarValue = str.Percentage;
                Console.WriteLine($"Read {StatusBarValue}% of the file");
            }
        }
    }
}
