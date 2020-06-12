using NUnit.Framework;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions.Test
{
    [TestFixture]
    public class BranchSumsTests
    {
        [Test]
        public void BranchSum_Should_AddNewNodeToTree_When_GivenAnInteger()
        {
            //arrange
            var BST = new BST(8);
            var sut = new int[] { 2,4,5,8,9,10,6,7 };
            foreach (var number in sut)
            {
                BST.Insert(number);
            }

            //act
            var results = BranchSum.BranchSums(BST);

            //assert
            Assert.That(results.Count, Is.GreaterThan(1));
        }
    }
}
