using System;

static public class Validation
{
    static public bool isInputValid(string input)
    {
        return IsLengthValid(input) && IsPositiveInteger(input);
    }
    static private bool IsLengthValid(string input)
    {
        return input.Length == 4;
    }

    static private bool IsPositiveInteger(string input)
    {
        int number;
        return Int32.TryParse(input, out number) && number > 0;
    }
}
