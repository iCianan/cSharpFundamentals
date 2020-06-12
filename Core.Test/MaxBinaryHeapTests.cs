using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Core.Test
{
    [TestFixture]
    public class MaxBinaryHeapTests
    {
        [Test]
        public void Insert_Should_ReturnArray()
        {
            //arrange
            var heap = new MaxBinaryHeap();
            foreach (var item in collection)
            {

            }
            //act
            heap.Insert(55);

            //assert
            Assert.That(heap.values[0], Is.EqualTo(55));
        }

        [Test]
        public void Insert_Should_BubbleLargestNumberToTop()
        {
            //arrange
            var heap = new MaxBinaryHeap() 
            {
                values = { 41,39,33,18,27,12 }
            };

            //act       
            heap.Insert(55);

            //assert
            Assert.That(heap.values[0], Is.EqualTo(55));
        }
    }
}
