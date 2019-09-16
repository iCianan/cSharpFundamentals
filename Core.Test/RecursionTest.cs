using Core;
using NUnit.Framework;

namespace Tests
{
  public class Tests
  {
    Recursion recursion;

    [SetUp]
    public void Setup()
    {
      recursion = new Recursion();
    }

    [Test]
    public void ShowerWorks()
    {
      string actual = recursion.TakeShower();
      string expected = "Showering";

      Assert.That(actual, Is.EqualTo(expected));
    }
  }
}