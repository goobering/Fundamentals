using NUnit.Framework;
using Fundamentals.Services;

namespace Fundamentals.Tests
{
    [TestFixture]
    public class TestSeriesAP
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSingleWordLowerCaseStringReverses()
        {
            // Arrange
            var testString = "keyboard";
            // Act
            var result = ReverseStringService.Reverse(testString);
            // Assert
            Assert.AreEqual("draobyek", result);
        }

        [Test]
        public void TestSingleCharacterStringReverses()
        {
            // Arrange
            var testString = "k";
            // Act
            var result = ReverseStringService.Reverse(testString);
            // Assert
            Assert.AreEqual("k", result);
        }

        [Test]
        public void TestSentenceStringReverses()
        {
            // Arrange
            var testString = "This is a test string.";
            // Act
            var result = ReverseStringService.Reverse(testString);
            // Assert
            Assert.AreEqual(".gnirts tset a si sihT", result);
        }

        [Test]
        public void TestEmptyStringReverses()
        {
            // Arrange
            var testString = string.Empty;
            // Act
            var result = ReverseStringService.Reverse(testString);
            // Assert
            Assert.AreEqual(string.Empty, result);
        }

        [Test]
        public void TestBlankStringReverses()
        {
            // Arrange
            var testString = "";
            // Act
            var result = ReverseStringService.Reverse(testString);
            // Assert
            Assert.AreEqual("", result);
        }
    }
}