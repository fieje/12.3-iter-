using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTests; 

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestSumOfPositiveValues()
        {
            LinkedList list = new LinkedList();
            list.Add(2);
            list.Add(-5);
            list.Add(10);
            list.Add(7);
            list.Add(-3);

            int sumOfPositives = list.SumOfPositiveValues();

            Assert.AreEqual(19, sumOfPositives);
        }
    }
}
