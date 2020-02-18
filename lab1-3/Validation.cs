static public class Validation
{
    static public bool isInputValid(string input)
    {
        return IsLengthValid(input) && IsPositiveInteger(input);
    }
    static private bool IsLengthValid(string input)
    {
        //return input.Length == 4;
        return int.TryParse(input, out int number) && number > 999;
    }

    static private bool IsPositiveInteger(string input)
    {
        return int.TryParse(input, out int number) && number > 0;
    }
}
