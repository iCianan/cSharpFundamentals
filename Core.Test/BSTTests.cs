
using NUnit.Framework;

namespace Core.Test
{
    public class BSTTests
    {
        private int[] sut;
        [SetUp]
        public void Setup()
        {
            sut = new int[] { -11, 3, 6, 8, 11, 14, 21 };
        }

        [Test]
        public void Insert_Should_AddNewNodeToLeftChild_When_ParentIsLarger()
        {
            //arrange
            var BST = new BST(7);

            //act
            var result = BST.Insert(3);

            //assert
            Assert.That(BST.left, Is.EqualTo(result));
        }
        [Test]
        public void Insert_Should_AddNewNodeToRightChild_When_ParentIsSmaller()
        {
            //arrange
            var BST = new BST(3);

            //act
            var result = BST.Insert(7);

            //assert
            Assert.That(BST.right, Is.EqualTo(result));
        }

        [Test]
        public void Insert_Should_AddNewNodeToTree_When_GivenAnInteger()
        {
            //arrange
            var BST = new BST(3);

            //act
            foreach (var number in sut)
            {
                BST.Insert(number);
            }

            //assert
            Assert.That(BST.right.right.value, Is.EqualTo(6));
        }

        [Test]
        public void Contains_Should_ReturnTrue_When_TreeContainsRequestedValue()
        {
            //arrange
            var BST = new BST(3);

            //act
            foreach (var number in sut)
            {
                BST.Insert(number);
            }

            var results = BST.Contains(21);

            //assert
            Assert.That(results, Is.True);
        }

        [Test]
        public void Contains_Should_ReturnFalse_When_TreeDoesntContainsRequestedValue()
        {
            //arrange
            var BST = new BST(3);

            //act
            foreach (var number in sut)
            {
                BST.Insert(number);
            }

            var results = BST.Contains(57);

            //assert
            Assert.That(results, Is.False);
        }
    }
}