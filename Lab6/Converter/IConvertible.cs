namespace Converter
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
            return $"Converted {value}";
        }

        public string ConvertToVB(string value)
        {
            return $"Converted {value}";
        }
    }

    public class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CheckCodeSyntax(string value, string lang)
        {
            return false;
        }
    }
}