using NUnit.Framework;
using Fundamentals.Objects;

namespace Fundamentals.Tests
{
    [TestFixture]
    class TestSinglyLinkedList
    {
        SinglyLinkedList<int> testList;

        [SetUp]
        public void Setup()
        {
            testList = new SinglyLinkedList<int>();
        }

        [Test]
        public void TestNewListHasZeroLength()
        {
            // Arrange
            // Empty testList already instantiated
            // Act
            // Empty testList already instantiated
            // Assert
            Assert.AreEqual(0, testList.Length);
        }

        [Test]
        public void TestListLengthIncreasesBy1WhenNodeAdded()
        {
            // Arrange
            // Empty testList already instantiated
            // Act
            testList.Add(10);
            // Assert
            Assert.AreEqual(1, testList.Length);
        }

        [Test]
        public void TestListAddsNodeCorrectly()
        {
            // Arrange
            // Empty testList already instantiated
            // Act
            testList.Add(10);
            // Assert
            Assert.AreEqual(10, testList.GetLastNode().Data);
        }

        [Test]
        public void TestListDeletesNodeCorrectly()
        {
            // Arrange
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            // Act
            testList.Delete(20);
            // Assert
            Assert.AreEqual(2, testList.Length);
            Assert.AreEqual(30, testList.GetLastNode().Data);
        }

        [Test]
        public void TestListDeletesLastNodeCorrectly()
        {
            // Arrange
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            // Act
            testList.DeleteLastNode();
            // Assert
            Assert.AreEqual(20, testList.GetLastNode().Data);
            Assert.AreEqual(2, testList.Length);
            Assert.IsNull(testList.GetLastNode().Next);
        }

        [Test]
        public void TestListDeletesLastNodeWhenOnlyOneNode()
        {
            // Arrange
            testList.Add(10);
            // Act
            testList.DeleteLastNode();
            // Assert
            Assert.AreEqual(0, testList.Length);
            Assert.IsNull(testList.GetLastNode());
        }

        [Test]
        public void TestCanFindFirstNodeWithSpecifiedData()
        {
            // Arrange
            testList.Add(10);
            testList.Add(20);
            testList.Add(30);
            // Act
            var result = testList.Find(20);
            // Assert
            Assert.AreEqual(20, result.Data);
        }
    } 
}