using System;
using Xunit;
using RomanNumeralConverter;

namespace RomanNumeralsTest
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(9, "IX")]
        public void ShouldReturnConvertedStringWhenSingleDigitIsGiven(int input, string output)
        {
            Assert.Equal(output, Program.ConvertToRomanNumeral(input));
        }

        [Theory]
        [InlineData(11, "XI")]
        [InlineData(402, "CDII")]
        [InlineData(905, "CMV")]
        [InlineData(1025, "MXXV")]
        public void ShouldReturnConvertedStringWhenMultipleDigitsGiven(int input, string output)
        {
            Assert.Equal(output, Program.ConvertToRomanNumeral(input));   
        }


    }
}