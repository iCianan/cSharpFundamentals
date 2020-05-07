using NUnit.Framework;
using Questions;


namespace Questions.Test
{
    public class BalancedBracketsTests
    {
        public BalancedBrackets sut { get; set; }

        [SetUp]
        public void Setup()
        {
           sut = new BalancedBrackets(); 

        }

        [Test]
        public void ParenthesisOnly_Should_ReturnTrue_When_GivenAnBalancedExpression()
        {            
            string example = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
            bool actual = sut.ParenthesisOnly(example);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void BunchOfBrackets_Should_ReturnTrue_When_GivenAnBalancedExpression()
        {
            string example = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
            bool actual = sut.BunchOfBrackets(example);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void BunchOfBrackets_Should_ReturnTrue_When_GivenAnBalancedExpressionWithMultipleBrackets()
        {
            string example = "{[[[[({(}))]]]]}";
            bool actual = sut.BunchOfBrackets(example);

            Assert.That(actual, Is.False);
        }

    }
}
