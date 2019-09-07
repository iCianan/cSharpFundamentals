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
        public void ShouldComputeAccurateStatistics()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(72.3);
            book.AddGrade(91.3);
            book.AddGrade(97.7);
            //act
            var results = book.ComputeStatistics();
           

            //assert
            Assert.That(results.High, Is.EqualTo(97.7));
            Assert.That(results.Low, Is.EqualTo(72.3d));
            Assert.That(results.Average, Is.EqualTo(87.1).Within(0.1));
            
        }

        [Test]
        public void ShouldDenyEnterLargeNumbers()
        {
            var book = new Book("");
            book.AddGrade(105);

            var results = book.Grades;

            Assert.That(results.Contains(105), Is.False);


            
        }
    }
}