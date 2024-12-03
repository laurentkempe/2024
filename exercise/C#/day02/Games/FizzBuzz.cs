using LanguageExt;

namespace Games;

public static class FizzBuzz
{
    public const int Min = 1;
    public const int Max = 100;

    public static Option<string> Convert(int input)
    {
        return IsOutOfRange(input)
            ? Option<string>.None
            : ConvertSafely(input);
    }

    private static string ConvertSafely(int input)
    {
        var isFizz = Is(3, input);
        var isBuzz = Is(5, input);
        var isWhizz = Is(7, input);
        var isBang = Is(11, input);

        return (isFizz, isBuzz, isWhizz, isBang) switch
        {
            (true, true, false, false) => "FizzBuzz",
            (true, false, true, false) => "FizzWhizz",
            (true, false, false, true) => "FizzBang",
            (true, false, false, false) => "Fizz",
            (false, true, false, false) => "Buzz",
            (false, false, true, false) => "Whizz",
            (false, false, false, true) => "Bang",
            _ => input.ToString()
        };
    }
    
    private static bool Is(int divisor, int input)
    {
        return input % divisor == 0;
    }

    private static bool IsOutOfRange(int input)
    {
        return input is < Min or > Max;
    }
}