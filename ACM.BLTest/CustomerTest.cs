using ACM.BL;
using NUnit.Framework;

namespace ACM.Tests
{
  public class CustomerTest
  {
    public Customer Customer { get; set; }

    [SetUp]
    public void Setup()
    {
      Customer = new Customer();
    }

    [Test]
    public void FullNamePropIsWorking()
    {
      Customer.FirstName = "Keenan";
      Customer.LastName = "Benning";

      string expected = "Keenan, Benning";

      string actual = Customer.FullName;

      Assert.That(expected, Is.EqualTo(actual));


    }
  }
}