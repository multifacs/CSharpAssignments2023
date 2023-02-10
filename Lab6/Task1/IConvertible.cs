namespace Task1
{
    public interface IConvertible
    {
        string ConvertToCSharp(string value);
        string ConvertToVB(string value);
    }

    public interface ICodeChecker
    {
        bool CheckCodeSyntax(string value, string lang);
    }

    public class ProgramConverter : IConvertible
    {
        public string ConvertToCSharp(string value)
        {
            return $"Converted {value} to C#";
        }

        public string ConvertToVB(string value)
        {
            return $"Converted {value} to VB";
        }
    }

    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string value, string lang)
        {
            return true;
        }
    }
}