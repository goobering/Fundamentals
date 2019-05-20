using NUnit.Framework;
using Fundamentals.Services;

namespace Fundamentals.Tests
{
    [TestFixture]
    class TestReverseWords
    {
        [Test]
        public void TestReverseReversesSentenceWordOrder()
        {
            // Arrange
            var input = "This is a test sentence";
            // Act
            var result = ReverseWordsService.Reverse(input);
            // Assert
            Assert.AreEqual("sentence test a is This", result);
        }

        [Test]
        public void TestReverseReversesSingleWordOrder()
        {
            // Arrange
            var input = "This";
            // Act
            var result = ReverseWordsService.Reverse(input);
            // Assert
            Assert.AreEqual("This", result);
        }

        [Test]
        public void TestReverseReversesSentenceWithPunctuation()
        {
            // Arrange
            var input = "This, is a test.";
            // Act
            var result = ReverseWordsService.Reverse(input);
            // Assert
            Assert.AreEqual("test. a is This,", result);
        }
    }
}