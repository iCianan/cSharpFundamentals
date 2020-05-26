using NUnit.Framework;
using Questions;
using System;

namespace Questions.Test
{
    public class NthFibonacciTests
    {
        [Test]
        public void GetNthFib_Should_ReturnOne_When_GivenTwoAsInput()
        {
            //arrange
            var input = 2;

            //act
            var result = NthFibonacci.GetNthFib(input);

            //assert
            Assert.That(result, Is.EqualTo(1)); 
        }

    }
}
