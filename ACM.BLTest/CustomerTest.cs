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


      string expected = "Benning, Keenan";

      string actual = Customer.FullName;

      Assert.That(expected, Is.EqualTo(actual));
    }
    [Test]
    public void StaticTypeChecker()
    {
      Customer.InstanceCount++;

      Assert.That(Customer.InstanceCount, Is.EqualTo(1));
    }
  }
}