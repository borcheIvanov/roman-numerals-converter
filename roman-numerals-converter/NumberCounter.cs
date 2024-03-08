namespace roman_numerals_converter;

public class NumberCounter
{
    private enum RomanNumbers
    {
        I,
        V,
        X,
        L,
        C,
        D,
        M
    };

    private Dictionary<RomanNumbers, int> Counters = new();

    public NumberCounter()
    {
        foreach (var rn in Enum.GetValues<RomanNumbers>())
        {
            Counters[rn] = 0;
        };
    }

    private void ReadChar(char c)
    {
        if (c == RomanNumbers.I.ToString()[0])
        {
            Counters[RomanNumbers.I] += 1;
        }

        if (c == RomanNumbers.V.ToString()[0]) {
            if (Counters[RomanNumbers.I] > 0) {
                Counters[RomanNumbers.V] += 3;
            } else {
                Counters[RomanNumbers.V] += 5;
            }
        }

        if (c == RomanNumbers.X.ToString()[0]) {
            if (Counters[RomanNumbers.I] > 0) {
                Counters[RomanNumbers.X] += 8;
            } else {
                Counters[RomanNumbers.X] += 10;
            }
        }

        if (c == RomanNumbers.L.ToString()[0]) {
            if (Counters[RomanNumbers.X] > 0) {
                Counters[RomanNumbers.L] += 30;
            } else {
                Counters[RomanNumbers.L] += 50;
            }
        }

        if (c == RomanNumbers.C.ToString()[0]) {
            if (Counters[RomanNumbers.X] > 0)
            {
                Counters[RomanNumbers.C] += 80;
            }
            else
            {
                Counters[RomanNumbers.C] += 100;
            }
        }

        if (c == RomanNumbers.D.ToString()[0]) {
            if (Counters[RomanNumbers.C] > 0)
            {
                Counters[RomanNumbers.D] += 300;
            }
            else
            {
                Counters[RomanNumbers.D] += 500;
            }
        }

        if (c == RomanNumbers.M.ToString()[0]) {
            Counters[RomanNumbers.M] += 1000;
        }
    }

    public int Result()
    {
        return Counters.Sum(x => x.Value);
    }

    public void Convert(string number)
    {
        foreach (var c in number.ToUpper())
        {
            ReadChar(c);
        }
    }
}
