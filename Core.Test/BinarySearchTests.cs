using NUnit.Framework;

namespace Core.Test
{
    public class BinarySearchTests
    {
        private int[] sut;
        [SetUp]
        public void Setup()
        {
            sut = new int[] { -11, 3, 6, 8, 11, 14, 21 };
        }

        [Test]
        [Category("InsertionSort")]
        public void BinarySearch_Should_ReturnTrue_When_TargetIsFound()
        {
            //arrange
            var sampleArray = sut;

            //act
            var result = BinarySearch.Search(sampleArray, 3);

            //assert
            Assert.That(result, Is.True);
        }
        [Test]
        [Category("InsertionSort")]
        public void BinarySearch_Should_ReturnFalse_When_TargetIsNotFound()
        {
            //arrange
            var sampleArray = sut;

            //act
            var result = BinarySearch.Search(sampleArray, 77);

            //assert
            Assert.That(result, Is.False);
        }

    }
}