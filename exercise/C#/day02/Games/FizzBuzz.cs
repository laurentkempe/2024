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

    private static string ConvertSafely(int input) => Rules.FizzBuzz(input);

    private static bool IsOutOfRange(int input)
    {
        return input is < Min or > Max;
    }
}