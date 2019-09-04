using NUnit.Framework;
using System;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Test]
        public void ShouldReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;   
            
            Assert.That(book1, Is.SameAs(book2));
        }
        [Test]
        public void ShouldReferenceDifferentObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
 
            Assert.That(book1, !Is.SameAs(book2));
        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
