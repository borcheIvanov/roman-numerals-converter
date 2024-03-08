// See https://aka.ms/new-console-template for more information

using System;
using roman_numerals_converter;

Console.WriteLine("Hello, World!");


 var service = new Service();
var result =  service.ConvertToArabic(Console.ReadLine()!);

Console.WriteLine(result);
