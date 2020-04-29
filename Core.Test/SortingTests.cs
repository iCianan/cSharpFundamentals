using Core;
using NUnit.Framework;


namespace Core.Test
{
    public class SortingTests
    {
        private int[] unsortedArray;
        private int[] sorted;
        [SetUp]
        public void Setup()
        {
            unsortedArray = new int[] { 21, 11, -11, 8, 3, 6, 14, 9 };
            sorted = new int[] { -11, 3, 6, 8, 9, 11, 14, 21 };
        }

        [Test]
        [Category("InsertionSort")]
        public void InsertionSort_Should_ReturnEmptyArray_When_InputArrayIsEmpty()
        {
            int[] expected = { };
            int[] actual = InsertionSort.Sort(expected);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("InsertionSort")]
        public void InsertionSort_Should_ReturnSortedArray_When_GivenNonEmptyArray()
        {         
            int[] actual = InsertionSort.Sort(unsortedArray);

            Assert.That(actual, Is.EqualTo(sorted));
        }

        [Test]
        [Category("MergeSort")]
        public void MergeSort_Should_ReturnEmptyArray_When_InputArrayIsEmpty()
        {
            int[] expected = { };
            int[] actual = MergeSort.Sort(expected);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        [Category("MergeSort")]
        public void MergeSort_Should_ReturnSortedArray_When_GivenNonEmptyArray()
        {
            int[] actual = MergeSort.Sort(unsortedArray);

            Assert.That(actual, Is.EqualTo(sorted));
        }

        [Test]
        [Category("QuickSort")]
        public void QuickSort_Should_ReturnEmptyArray_When_InputArrayIsEmpty()
        {
            int[] expected = { };
            QuickSort.Sort(expected, 0, expected.Length);

            Assert.That(expected, Is.Empty);
        }

        [Test]
        [Category("QuickSort")]
        public void QuickSort_Should_ReturnSortedArray_When_GivenNonEmptyArray()
        {
            QuickSort.Sort(unsortedArray, 0, unsortedArray.Length -1);
            int[] actual = unsortedArray;
            

            Assert.That(actual, Is.EqualTo(sorted));
        }
    }
}
