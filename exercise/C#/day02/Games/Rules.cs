namespace Games;

public static class Rules
{
    public static string FizzBuzz(int input)
    {
        return (isFizz: Is(3, input), isBuzz: Is(5, input), isWhizz: Is(7, input), isBang: Is(11, input)) switch
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

        static bool Is(int divisor, int input) => input % divisor == 0;
    }
}