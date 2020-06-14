using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using NUnit.Framework;
namespace Questions.Test
{
    [TestFixture]
    public class RemoveKthNodeFromEndTests
    {
        [Test]
        public void TestCase1()
        {
            var payload = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var list = new DoublyLinkedList<int>();
            foreach (var item in payload)
            {
                list.Add(item);
            }

            RemoveKthNodeFromEnd.Remove(list, 10);

            Assert.That(list.Count, Is.EqualTo(9));
        }
    }
}
