using DataStructureLIB;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProjectDataStrucute
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void InitializeEmptyTest()
        {
            LinkedList<int> ints = new LinkedList<int>();
            Assert.AreEqual(0, ints.Count);
        }
    }
}
