using NUnit.Framework;
using Fundamentals.Services;

namespace Fundamentals.Tests
{
    [TestFixture]
    class TestReverseEachWord
    {
        [Test]
        public void TestReversesEachWordInASentence()
        {
            // Arrange
            var input = "This is a sentence.";
            // Act
            var result = ReverseEachWordService.Reverse(input);
            // Assert
            Assert.AreEqual("sihT si a .ecnetnes", result);
        }

        [Test]
        public void TestReversesSingleWordInASentence()
        {
            // Arrange
            var input = "This";
            // Act
            var result = ReverseEachWordService.Reverse(input);
            // Assert
            Assert.AreEqual("sihT", result);
        }

        [Test]
        public void TestReversesEmptyString()
        {
            // Arrange
            var input = string.Empty;
            // Act
            var result = ReverseEachWordService.Reverse(input);
            // Assert
            Assert.AreEqual(string.Empty, result);
        }
    }
}