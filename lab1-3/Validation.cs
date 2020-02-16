using System;

static public class Validation
{
    static public bool IsLengthValid(string input)
    {
        return input.Length == 4 ? true : false;
    }

    static public bool IsPositiveInteger(string input)
    {
        int number;
        return Int32.TryParse(input, out number) && number > 0 ? true : false;
    }
}
