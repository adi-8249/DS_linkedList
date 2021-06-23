using LinedListPrograms;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestCaseLinkedList.Test
{
    public class Tests
    {
        LinkedList list = new LinkedList();

        [Test]
        //By this test case we can search the element
        public void SearchingNode()
        {
            //Arrange
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Assert
            Node node = list.Search(30);
            //Act
            Assert.AreEqual(30, node.value);
            Assert.Pass();
        }
    }
}