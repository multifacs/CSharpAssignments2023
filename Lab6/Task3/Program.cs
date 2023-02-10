using Task3;
internal class Program
{
    private static void Main(string[] args)
    {
        string password = "SomePassword";
        using (StreamWithPassword str = new StreamWithPassword(
            new FileStream(
                "sample-2mb-text-file.txt",
                FileMode.Open,
                FileAccess.Read),
            password))
        {
            byte[] bytes = new byte[str.Length];
            int numBytesToRead = (int)str.Length;
            int numBytesRead = 0;
            while (numBytesToRead > 0)
            {
                int n;
                do
                {
                    Console.WriteLine("Enter password:");
                    string enteredPassword = Console.ReadLine();
                    str.EnterPassword(enteredPassword);

                    n = str.Read(bytes, numBytesRead, numBytesToRead);
                } while (n == -2);

                if (n == 0)
                    break;

                numBytesRead += n;
                numBytesToRead -= n;
            }
            Console.WriteLine("File read");
        }
    }
}