using NUnit.Framework;
using Fundamentals.Services;

namespace Fundamentals.Tests
{
    [TestFixture]
    class TestCountCharacters
    {
        [Test]
        public void TestLowercaseStringReturnsCorrectCounts()
        {
            // Arrange
            var input = "hello world";
            // Act
            var result = CountCharactersService.CountCharacters(input);
            // Assert
            Assert.AreEqual("h - 1\ne - 1\nl - 3\no - 2\nw - 1\nr - 1\nd - 1\n", result);
        }
    }
}