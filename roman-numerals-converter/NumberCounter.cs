namespace roman_numerals_converter;

public class NumberCounter
{
    private int _ones = 0;
    private int _fives = 0;
    private int _tens = 0;
    private int _fifties = 0;
    private int _hundreds = 0;
    private int _fiveHundreds = 0;
    private int _thousands = 0;
    public void ReadChar(char c)
    {
        if (c == 'i') {
            _ones++;
        }

        if (c == 'v') {
            if (_ones > 0) {
                _fives += 3;
            } else {
                _fives += 5;
            }
        }

        if (c == 'x') {
            if (_ones > 0) {
                _tens += 8;
            } else {
                _tens += 10;
            }
        }

        if (c == 'l') {
            if (_tens > 1) {
                _fifties += 30;	
            } else {
                _fifties += 50;
            }
        }

        if (c == 'c') {
            _hundreds += 100;
        }

        if (c == 'd') {
            _fiveHundreds += 500;
        }

        if (c == 'm') {
            _thousands += 1000;
        }
    }


    public int Result()
    {
        return _thousands + _fiveHundreds + _hundreds + _fifties + _tens + _fives + _ones;
    }

    public void Convert(string number)
    {
        foreach (var c in number)
        {
            ReadChar(c);
        }
    }
}
