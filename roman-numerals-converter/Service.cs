namespace roman_numerals_converter;

public class Service
{
    public string ConvertToArabic(string number)
    {
        var counter = new NumberCounter();
        counter.Convert(number);
		
        return counter.Result().ToString();
    }
}
