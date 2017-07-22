using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1.Model;

namespace UnitTestProject1
{
    [TestClass]
    public class ItemUnitTest
    {
        private Item CreateItemForTest(int id)
        {
            var item1 = new Item()
            {
                Id = id,
                Name = "Item" + id,
                Description = "Test item" + id,
                Height = 20,
                Width = 25,
                Weight = 10
            };
            return item1;
        }

        [TestMethod]
        public void AreDifferent_DummyTest()
        {
            var item1 = CreateItemForTest(1);
            var item2 = CreateItemForTest(2);

            Assert.AreNotEqual(item1, item2);
        }

        [TestMethod]
        public void AreDifferentName_DummyTest()
        {
            var item1 = CreateItemForTest(1);
            var item2 = CreateItemForTest(2);

            Assert.AreNotEqual(item1.Name, item2.Name);
            Assert.AreNotEqual(item1.Description, item2.Description);
        }
    }
}
