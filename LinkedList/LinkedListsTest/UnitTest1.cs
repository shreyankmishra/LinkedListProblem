using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace LinkedListsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            LinkedLists list = new LinkedLists();
            list.Add(12);
            list.Add(30);
            list.Add(56);
            Assert.IsTrue(list.Search(30));
        }
    }
}
