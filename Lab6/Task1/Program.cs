using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        var objects = new List<ProgramConverter>()
{
    new ProgramConverter(),
    new ProgramConverter(),
    new ProgramConverter(),
    new ProgramHelper()
};

        objects.ForEach(obj =>
        {
            if (obj is ICodeChecker)
            {
                ProgramHelper newObj = (ProgramHelper)obj;
                Console.WriteLine(newObj.ConvertToCSharp("some code"));
                Console.WriteLine(newObj.ConvertToVB("some code"));
                Console.WriteLine("Code converted: " + newObj.CheckCodeSyntax("some code", "c sharp"));
            }
            else
            {
                Console.WriteLine(obj.ConvertToCSharp("some code"));
                Console.WriteLine(obj.ConvertToVB("some code"));
            }
            Console.WriteLine();
        });
    }
}