using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NUnit.Framework;

namespace Questions.Test
{
    [TestFixture]
    public class ValidateBSTTests
    {
        [Test]
        public void Insert_Should_AddNewNodeToTree_When_GivenAnInteger()
        {
            //arrange
            var BST = new BST(10);
            var sut = new[] { 15,22,13,14,5,5,2,1};
            foreach (var number in sut)
            {
                BST.Insert(number);
            }

            //act
            bool results = ValidateBST.ValidateInOrder(BST);

            //assert
            Assert.That(results, Is.True);
        }
    }
}
