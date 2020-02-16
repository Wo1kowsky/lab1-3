using System;

public class Validation
{
	public Validation()
	{
	}

    public bool isLengthValid(string input)
    {
        return input.Length == 4 ? true : false;
    }

    public bool isPositiveInteger(string input)
    {
        int number;
        return Int32.TryParse(input, out number) && number > 0 ? true : false;
    }
}
