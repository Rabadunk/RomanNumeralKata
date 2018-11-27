using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RomanNumerals
{
    public class Tests
    {
        [Theory]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        public void ShouldReturnConvertedStringForSingleSimpleInteger(int input, string expectedOutput)
        {
            Assert.Equal(expectedOutput, ConvertToRomanNumeral(input));
        }
        
        [Theory]
        [InlineData(3, "III")]
        [InlineData(8, "VIII")]
        [InlineData(7, "VII")]
        public void ShouldReturnConvertedStringForSingleDifficultInteger(int input, string expectedOutput)
        {
            Assert.Equal(expectedOutput, ConvertToRomanNumeral(input));
        }
        
        [Theory]
        [InlineData(13, "XIII")]
        [InlineData(1188, "MCLXXXVIII")]
        public void ShouldReturnConvertedStringForLargeDifficultIntegers(int input, string expectedOutput)
        {
            Assert.Equal(expectedOutput, ConvertToRomanNumeral(input));
        }
    }
}