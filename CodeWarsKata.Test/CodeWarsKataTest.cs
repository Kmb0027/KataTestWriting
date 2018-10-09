using System;
using Xunit;



namespace CodeWarsKata.Test
{
    public class CodeWarsKataTest
    {
        [Theory]
        [InlineData(3, "Hey", "HeyHeyHey")]
        [InlineData(0, "L", "")]
        public void ShouldReturnRepeatedString(int n, string s, string expected)
        {
            // arrange
            KataSolutions kataSolutions = new KataSolutions();

            // act
            string actual = KataSolutions.RepeatString(n, s);

            // assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 0)]
        [InlineData(new int[] { 0, 2, 4, 6, 8 }, 20)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -6)]
        public void IsSumOfPositive(int[] arr, int expected)
        {
            // arrange
            KataSolutions kataSolutions = new KataSolutions();

            // act
            int actual = KataSolutions.PositiveSum(arr);

            // assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData('+', 2, 2, 4)]
        [InlineData('-', 2, 2, 0)]
        [InlineData('*', 3, 3, 9)]
        [InlineData('*', 3, -3, 9)]
        [InlineData('*', 0, 1, 0)]
        [InlineData('/', 1, 2, 0.5)]
        [InlineData('/', 10, 5, 2)]
        [InlineData('/', 1, 0, null)]
        public void PerformBasicOp(char operation, double value1, double value2, double expected)
        {
            // arrange
            KataSolutions kataSolutions = new KataSolutions();

            // act
            double actual = KataSolutions.BasicOp(operation, value1, value2);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Mitchell", "Hello, Mitchell, welcome!")]
        [InlineData("", "Hello, , welcome!")]
        public void IsGreeted(string name, string expected)
        {
            // arrange
            KataSolutions kataSolutions = new KataSolutions();

            // act
            string actual = KataSolutions.Greet(name);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2000, 21)]
        [InlineData(1901, 20)]
        [InlineData(1500, 16)]
        [InlineData(1, 1)]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        public void YearGivesCentury(int year, int expected)
        {
            // arrange
            KataSolutions kataSolutions = new KataSolutions();

            // act
            int actual = KataSolutions.СenturyFromYear(year);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("The price is gonna be tree fiddy.", true)]
        [InlineData("The price is gonna be three fifty.", true)]
        [InlineData("The price is gonna be tree Fiddy.", true)]
        [InlineData("The price is gonna be $3.50.", true)]
        [InlineData("The price is gonna be four twenty.", false)]
        [InlineData("The price is gonna be $4.20", false)]
        [InlineData("", false)]
        [InlineData("null", false)]
        public void IsLochNess(string sentence, bool expected)
        {
            // arrange
            KataSolutions kataSolutions = new KataSolutions();

            // act
            bool actual = KataSolutions.TreeFiddy(sentence);

            // assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(true, "True")]
        [InlineData(false, "False")]
        public void IsWordFromBool(bool word, string expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            string actual = KataSolutions.BoolToWord(word);

            // assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(100, true)]
        public void IsPluralNeeded(double number, bool expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            bool actual = KataSolutions.Plural(number);

            // assert
            Assert.Equal(expected, actual);
        }
        //level 7
        [Theory]
        [InlineData(123984757543, 98475)]
        [InlineData(555847366274867746, 86774)]
        [InlineData(272839482748574343, 94827)]
        [InlineData(0, 0)]
        public void LargestFiveDigits(string numberString, int expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            int actual = KataSolutions.GetNumber(numberString);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("aa_bb_cc_dd_bb_ff", "bb", 2)]
        [InlineData("aaabbbcccddeedee", "ee", 2)]
        [InlineData("oijwoeiaweijioawej", "nope", 0)]
        [InlineData(null, null, null)]
        [InlineData("AAbbhhaaiiaaa", "AA", 1)]
        [InlineData("", "A", 0)]
        public void HowManySubstrings(string fullText, string searchText, int expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            int actual = KataSolutions.SubstringCount(fullText, searchText);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Hello there!", "!ereht olleH")]
        [InlineData("Spaces  matter", "rettam  secapS")]
        [InlineData("Chip is the best teacher ever!!", "!!reve rehcaet tseb eht si pihC")]
        [InlineData(null, null)]
        [InlineData(" _  ", "  _ ")]
        public void WordsReversed(string str, string expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            string actual = KataSolutions.ReverseWords(str);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("Hello there!", "there!", true)]
        [InlineData("Spaces  matter", "ter", true)]
        [InlineData("kljsdfiojwerjfdh", "koli", false)]
        [InlineData("ojafsdjoeri", "oerj", false)]
        [InlineData("", "fasdf", false)]
        [InlineData("asdkfjd ", " ", true)]
        public void FirstEndsWithSecond(string str, string end, bool expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            bool actual = KataSolutions.Solution(str, end);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(1, new int []{1, 2, 1, 4, 1, 3, 1} , 4)]
        [InlineData(55, new int []{4, 66, 55, 34, 55}, 2)]
        [InlineData(0, new int []{2, 4, 5, 6, 0, 3, 0}, 2)]
        [InlineData(-1, new int[] { -6, 4, -1, 6, -1, 3, -1 }, 3)]
        public void NumberOccured(int x, int[] xs, int expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            int actual = KataSolutions.NumberOfOccurrences(x, xs);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 9)]
        [InlineData(new int[] { 8, 5, 3, 7, 2, 6, 4, 1 }, 9)]
        [InlineData(new int[] { 6, 3, 2, 1, 5, 4, 8, 9 }, 7)]
        [InlineData(new int[] { 2, 8, 9, 7, 6, 5, 3, 4 }, 1)]
        public void FoundMissingElement(int[] sIA, int expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            int actual = KataSolutions.GetMissingElement(sIA);

            // assert
            Assert.Equal(expected, actual);
        }
        //level 6
        [Theory]
        [InlineData(10, 23)]
        [InlineData(5, 0)]
        [InlineData(0, 0)]
        [InlineData(null, null)]
        public void SumMultiplesOf3Or5(int value, int expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            int actual = KataSolutions.Solution(value);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new string[] {"Hello", "world!"}, "Hello, world!")]
        [InlineData(new string[] {"Run", "jump", "roll."}, "Run, jump and roll")]
        [InlineData(new string[] {"big", "", "fat"}, "big and fat")]
        [InlineData(new string[] {}, "")]
        [InlineData(new string[] {""}, "")]
        public void StringArrayFormatted(string[] words, string expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            string actual = KataSolutions.FormatWords(words);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("the-cow-jumped", "theCowJumped")]
        [InlineData("The-cow-jumped", "TheCowJumped")]
        [InlineData("", "")]
        [InlineData("1235", "1235")]
        [InlineData(null, null)]
        public void CamelCaseString(string str, string expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            string actual = KataSolutions.ToCamelCase(str);

            // assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(new string[] {"Mitchell"}, "Mitchell likes this")]
        [InlineData(new string[] { "Mitchell", "Chip" }, "Mitchell and Chip like this")]
        [InlineData(new string[] { "Mitchell", "Chip", "Brandon" }, "Mitchell, Chip, and Brandon like this")]
        [InlineData(new string[] { "Mitchell", "Chip", "Brandon", "Daniel", "Olivia" }, "Mitchell, Chip and 2 others like this")]
        [InlineData(null, null)]
        [InlineData(new string[] {}, null)]
        public void WhoLikes(string[] name, string expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            string actual = KataSolutions.Likes(name);

            // assert
            Assert.Equal(expected, actual);
        }
        //level 5
        [Theory]
        [InlineData(new int[] {1, 2, 0, 3, 0, 5}, new int[] {1, 2, 3, 5, 0, 0})]
        [InlineData(new int[] { 1, -2, 0, -3, 0, 5 }, new int[] { 1, -2, -3, 5, 0, 0 })]
        [InlineData(new int[] { 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0 })]
        [InlineData(new int[] { 1, 2, 4, 3, 6, 5 }, new int[] { 1, 2, 4, 3, 6, 5})]
        [InlineData(new int[] {}, new int[] {})]
        public void ZeroMovedToEnd(int[] arr, int[] expected)
        {
            // arrange
            KataSolutions katasolutions = new KataSolutions();

            // act
            int[] actual = KataSolutions.MoveZeroes(arr);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
