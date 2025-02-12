namespace roman_numerals_converter;

public class Service
{
    public string ConvertToArabic(string number)
    {
        var counter = new NumberCounter();
        var result = counter.Convert(number);
		
        return result.ToString();
    }
}
