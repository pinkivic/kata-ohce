using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Greeter
{
    private readonly IClock _clock;

    public Greeter(IClock clock)
    {
        _clock = clock;
    }
    public string Greet()
    {
        int hour = _clock.GetCurrentHour();
        return hour switch
        {
            (>=6) and (< 12) => "Good morning",
            (>=12) and (<= 19) => "Good afternoon",
            // Fun fact: (>=20) and (<6) does not compile because the compiler
            // thinks this statement is unreachable :P
            _ => "Good night",
        };
    }
}