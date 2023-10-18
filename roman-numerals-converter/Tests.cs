using FluentAssertions;
using Xunit;

namespace roman_numerals_converter;

public class Tests
{
	[Theory]
	[InlineData("i", "1")]
	[InlineData("v", "5")]
	[InlineData("x", "10")]
	[InlineData("l", "50")]
	[InlineData("c", "100")]
	[InlineData("d", "500")]
	[InlineData("m", "1000")]
	public void Convert_single_roman_number_to_arabic(string number, string expected)
	{
		var sut = new Service();
		var result = sut.ConvertToArabic(number);

		result.Should().Be(expected);
	}

	[Fact]
	public void Convert_two_to_arabic()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("ii");

		result.Should().Be("2");
	}

	[Fact]
	public void Convert_5()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("v");

		result.Should().Be("5");
	}

	[Fact]
	public void Convert_8()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("viii");

		result.Should().Be("8");
	}

	[Fact]
	public void Convert_17()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("xvii");

		result.Should().Be("17");
	}
	
	[Fact]
	public void Convert_33()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("xxxiii");

		result.Should().Be("33");
	}
	
	[Fact]
	public void Convert_25()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("xxv");

		result.Should().Be("25");
	}

	[Fact]
	public void Convert_2778()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("mmdcclxxviii");

		result.Should().Be("2778");
	}
	
	[Fact]
	public void Convert_4()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("iv");

		result.Should().Be("4");
	}
	
	[Fact]
	public void Convert_9()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("ix");

		result.Should().Be("9");
	}
	
	[Fact]
	public void Convert_49()
	{
		var sut = new Service();
		var result = sut.ConvertToArabic("xlix");

		result.Should().Be("49");
	}
}