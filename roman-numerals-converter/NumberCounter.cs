namespace roman_numerals_converter;

public class NumberCounter
{
    private readonly Dictionary<char, int> _romanNumbers = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 }
    };

    public int Convert(string roman)
    {
        roman = roman.ToUpper();
        
        var totalValue = 0;
        var previousValue = 0;

        foreach (var c in roman)
        {
            if (!_romanNumbers.TryGetValue(c, out var value))
            {
                throw new ArgumentException($"Invalid Roman numeral character: {c}");
            }

            if (value > previousValue)
            {
                // Adjust for previous addition
                totalValue += value - 2 * previousValue;
            }
            else
            {
                totalValue += value;
            }

            previousValue = value;
        }

        return totalValue;
    }
}
