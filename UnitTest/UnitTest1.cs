using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using My_Project_PP04.Data;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 20000;
            Baskets baskets = new Baskets();
            baskets.Basket = new System.Collections.Generic.List<Bascet>
                {
                    new Bascet { Name = "Товар 1", Price = 100, Count = 80 },
                    new Bascet { Name = "Товар 2", Price = 50, Count = 40 },
                    new Bascet { Name = "Товар 3", Price = 1000, Count = 10 }
                };
            int result = MyUnitTest.ResultAllPrice(baskets);      
           
            Assert.AreEqual(expected, result);
        }
    }
}
