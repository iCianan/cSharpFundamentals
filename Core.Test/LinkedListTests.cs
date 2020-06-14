using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Test
{
    public class LinkedListTests
    {
        public DoublyLinkedList<int> list;

       [SetUp]
        public void Setup()
        {
            list = new DoublyLinkedList<int>();
        }

        [Test]
        public void DoublyLinkedList_Should_AddItemToEndOfList_When_GivenItem()
        {
            int item1 = 5;
            int item2 = 12;

            list.Add(item1);
            list.Add(item2);

            Assert.That(list.Head.Next, Is.EqualTo(list.Tail));
        }
        [Test]
        public void DoublyLinkedList_Should_RemoveItem_When_GivenIndex()
        {
            int item1 = 5;
            int item2 = 12;
            int item3 = 2;

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);

            Assert.That(list.RemoveAt(1), Is.EqualTo(item2));
        }

        [Test]
        public void PrintReversedLinkedList_Should_DisplayLinkedListInReverseOrder_When_NonEmptyLinkedListPassed()
        {
            //arrange
            var list = GetSampleLinkedList();

            //act
            list.PrintReversedLinkedList(list.Head);

            //assert
        }

        private DoublyLinkedList<int> GetSampleLinkedList()
        {
            var array = new int[] { 44, 21, 95, 36, 55, 47, 12, 1, 5, 6, 95 };
            var results = new DoublyLinkedList<int>();
            foreach (var item in array)
            {
                results.Add(item);
            }
            return results;
        }
    }
}
