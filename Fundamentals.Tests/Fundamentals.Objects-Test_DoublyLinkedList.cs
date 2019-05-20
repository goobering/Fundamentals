using NUnit.Framework;
using Fundamentals.Objects;

namespace Fundamentals.Tests
{
    [TestFixture]
    class TestDoublyLinkedList
    {
        private DoublyLinkedList<int> testList;

        [SetUp]
        public void Setup()
        {
            testList = new DoublyLinkedList<int>();
        }

        [Test]
        public void TestCanAddNodeToFrontOfEmptyList()
        {
            // Arrange
            // testList already instantiated
            // Act
            testList.AddToFront(10);
            // Assert
            Assert.AreEqual(1, testList.Length);
            Assert.AreEqual(10, testList.GetHeadNode().Data);
        }

        [Test]
        public void TestCanAddNodeToFrontOfPopulatedList()
        {
            // Arrange
            testList.AddToFront(10);
            // Act
            testList.AddToFront(20);
            // Assert
            Assert.AreEqual(2, testList.Length);
            Assert.AreEqual(20, testList.GetHeadNode().Data);
        }

        [Test]
        public void TestCanAddNodeToEndOfEmptyList()
        {
            // Arrange
            // testList already instantiated
            // Act
            testList.AddToEnd(10);
            // Assert
            Assert.AreEqual(1, testList.Length);
            Assert.AreEqual(10, testList.GetHeadNode().Data);
        }

        [Test]
        public void TestCanAddNodeToEndOfPopulatedList()
        {
            // Arrange
            testList.AddToFront(10);
            // Act
            testList.AddToEnd(20);
            // Assert
            Assert.AreEqual(2, testList.Length);
            Assert.AreEqual(20, testList.GetLastNode().Data);
        }

        [Test]
        public void CanDeleteLastNodeOfListWithSingleItem()
        {
            // Arrange
            testList.AddToEnd(10);
            // Act
            testList.DeleteLastNode();
            // Assert
            Assert.AreEqual(0, testList.Length);
            Assert.IsNull(testList.GetHeadNode());
        }

        [Test]
        public void CanDeleteLastNodeOfListWithMultipleItems()
        {
            // Arrange
            testList.AddToEnd(10);
            testList.AddToEnd(20);
            testList.AddToEnd(30);
            // Act
            testList.DeleteLastNode();
            // Assert
            Assert.AreEqual(2, testList.Length);
            Assert.AreEqual(20, testList.GetLastNode().Data);
        }

        [Test]
        public void CanDeleteFirstNodeOfListWithSingleItem()
        {
            // Arrange
            testList.AddToEnd(10);
            // Act
            testList.DeleteFirstNode();
            // Assert
            Assert.AreEqual(0, testList.Length);
            Assert.IsNull(testList.GetHeadNode());
        }

        [Test]
        public void CanDeleteFirstNodeOfListWithMultipleItems()
        {
            // Arrange
            testList.AddToEnd(10);
            testList.AddToEnd(20);
            testList.AddToEnd(30);
            // Act
            testList.DeleteFirstNode();
            // Assert
            Assert.AreEqual(2, testList.Length);
            Assert.AreEqual(20, testList.GetHeadNode().Data);
        }

        [Test]
        public void CanFindNodeWithSpecifiedValue()
        {
            // Arrange
            testList.AddToEnd(10);
            testList.AddToEnd(20);
            testList.AddToEnd(30);
            // Act
            var result = testList.Find(20);
            // Assert
            Assert.AreEqual(20, result.Data);
        }

        [Test]
        public void FindReturnsNullIfNoItemFound()
        {
            // Arrange
            // Empty testList already instantiated
            // Act
            var result = testList.Find(10);
            // Assert
            Assert.AreEqual(null, result);
        }
    }
}