using NUnit.Framework;
using Fundamentals.Services;

namespace Fundamentals.Tests
{
    [TestFixture]
    class TestPalindrome
    {
        public void Setup()
        {

        }

        [Test]
        public void TestPalindromeReturnsPalindromeOnEvenLengthSingleWordPalindrome()
        {
            // Arrange
            var input = "anna";
            // Act
            var result = PalindromeService.IsPalindrome(input);
            // Assert
            Assert.AreEqual("Palindrome", result);
        }

        [Test]
        public void TestPalindromeReturnsPalindromeOnOddLengthSingleWordPalindrome()
        {
            // Arrange
            var input = "annna";
            // Act
            var result = PalindromeService.IsPalindrome(input);
            // Assert
            Assert.AreEqual("Palindrome", result);
        }

        [Test]
        public void TestPalindromeReturnsNotPalindromeOnSingleWordNonPalindrome()
        {
            // Arrange
            var input = "banana";
            // Act
            var result = PalindromeService.IsPalindrome(input);
            // Assert
            Assert.AreEqual("Not Palindrome", result);
        }
    }
}