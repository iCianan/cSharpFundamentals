using NUnit.Framework;
using System;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldReturnGradeAverage()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(72.3);
            book.AddGrade(91.3);
            book.AddGrade(97.7);
            //act
            var results = book.ShowStatistics();
            var sut = Math.Round(results["Average"]);

            //assert
            Assert.That(sut, Is.EqualTo(87));
            
        }
    }
}