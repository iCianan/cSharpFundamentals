using NUnit.Framework;
using System;

namespace GradeBook.Tests
{
  public class BookTests
  {
    //[Test]
    //public void ShouldComputeAccurateStatistics()
    //{

    //  var stats = new Statistics();
    //  stats.ComputeGrades(Grades);
    //  //arrange
    //  var book = new InMemoryBook("");
    //  var stats = new 
    //  book.AddGrade(72.3);
    //  book.AddGrade(91.3);
    //  book.AddGrade(97.7);
    //  //act
    //  book.ComputeStatistics();


    //  //assert
    //  Assert.That(results.High, Is.EqualTo(97.7));
    //  Assert.That(results.Low, Is.EqualTo(72.3d));
    //  Assert.That(results.Average, Is.EqualTo(87.1).Within(0.1));
    //  Assert.That(results.Letter, Is.EqualTo('B'));
    //}

    [Test]
    public void ShouldNotAcceptLargeNumbers()
    {
      var book = new InMemoryBook("");
      var ex = Assert.Throws<ArgumentException>(
          () => book.AddGrade(105));
      Assert.That(ex.Message, Is.EqualTo("Invalid grade"));
    }
    [Test]
    public void ShouldReturnNewName()
    {
      var book1 = new InMemoryBook("Book 1");
      book1.ChangeName("New Name");     


      Assert.That(book1.Name, Is.EqualTo("New Name"));
    }
    [Test]
    public void ShouldReferenceDifferentObject()
    {
      var book1 = new InMemoryBook("Book 1");
      var book2 = new InMemoryBook("Book 2");

      Assert.That(book1, !Is.SameAs(book2));
    }
  }
}
