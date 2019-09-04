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
        public void ValueTypesAlsoPassByValue()
        {
            var x  = GetInt();
            SetInt(ref x);   
            
            Assert.That(x, Is.EqualTo(42));
        }
        [Test]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Keenan";
            var upper = MakeUpperCase(name);

            Assert.That(name, Is.EqualTo("Keenan"));
            Assert.That(upper, Is.EqualTo("KEENAN"));

        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Test]
        public void ShouldReferenceDifferentObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
 
            Assert.That(book1, !Is.SameAs(book2));
        }
        [Test]
        public void ShouldReturnNewName()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");


            Assert.That(book1.Name, Is.EqualTo("New Name"));
        }

        private void SetName(Book book, string name)
        {
            book.ChangeName(name);

        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
