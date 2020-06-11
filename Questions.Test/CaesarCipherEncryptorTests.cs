using NUnit.Framework;
using System;

namespace Questions.Test
{
    [TestFixture]
    public class CaesarCipherEncryptorTests
    {
        [Test]
        public void CaesarCipherEncryptor_Should_ReturnString_When_InputStringIsValid()
        {
            //arrange
            var input = "xyz";
            var key = 2;

            //act
            var results = CaesarCipherEncryptor.Encryptor(input, key);

            //assert
            Assert.That(results, Is.EqualTo("zab"));
        }
    }
}
