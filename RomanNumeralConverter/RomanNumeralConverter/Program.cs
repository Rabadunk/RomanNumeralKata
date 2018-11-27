using System;
using System.Collections.Generic;

namespace RomanNumeralConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number you want to convert to roman numerals: ");
            var input = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToRomanNumeral(input));
            Console.ReadLine();
        }

        public static string ConvertToRomanNumeral(int i)
        {
            var romanNumerals = new Dictionary<int, string>
            {
                {1000, "M"},
                {900, "CM"},
                {500, "D"},
                {400, "CD"},
                {100, "C"},
                {90, "XC"},
                {50, "L"},
                {40, "XL"},
                {10, "X"},
                {9, "IX"},
                {5, "V"},
                {4, "IV"},
                {1, "I"}
            };

            var count = i;
            var romanNumeral = "";
            
            while (count != 0 )
            {
                foreach (KeyValuePair<int, string> item in romanNumerals)
                {
                    if (count % item.Key < count)
                    {
                        romanNumeral += item.Value;
                        count = count - item.Key;
                        break;
                    }
                } 
            }

            return romanNumeral;
        }
    }
}