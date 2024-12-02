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

        return (isFizz, isBuzz, isWhizz) switch
        {
            (true, true, false) => "FizzBuzz",
            (true, false, false) => "Fizz",
            (false, true, false) => "Buzz",
            (false, false, true) => "Whizz",
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