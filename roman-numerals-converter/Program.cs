// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Hello, World!");


 var service = new Service();
var result =  service.ConvertToArabic(Console.ReadLine()!);

Console.WriteLine(result);

public class Service
{
	public string ConvertToArabic(string number)
	{
		var ones = 0;
		var fives = 0;
		var tens = 0;
		var fifties = 0;
		var hundreds = 0;
		var fiveHundreds = 0;
		var thousands = 0;
		
		foreach (var c in number) {
			if (c == 'i') {
				ones++;
			}

			if (c == 'v') {
				if (ones > 0) {
					fives += 3;
				} else {
					fives += 5;
				}
			}

			if (c == 'x') {
				if (ones > 0) {
					tens += 8;
				} else {
					tens += 10;
				}
			}

			if (c == 'l') {
				if (tens > 1) {
					fifties += 30;	
				} else {
					fifties += 50;
				}
			}

			if (c == 'c') {
				hundreds += 100;
			}

			if (c == 'd') {
				fiveHundreds += 500;
			}

			if (c == 'm') {
				thousands += 1000;
			}
		}
		
		
		return (thousands + fiveHundreds + hundreds + fifties + tens + fives + ones).ToString();
	}
}