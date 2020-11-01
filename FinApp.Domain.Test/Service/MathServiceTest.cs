using System.Collections.Generic;
using FinApp.Domain.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FinApp.Domain.Test.Service
{
    [TestClass]
    public class MathServiceTest
    {
        [TestMethod]
        public void ShouldGetEvenAndOddNumbers()
        {
            var mathService = new MathService();

            List<int> list = new List<int>();
            list.Add(3);
            list.Add(5);
            list.Add(2);
            list.Add(4);


            var result = mathService.Run(list);

            Assert.AreEqual(2, result.EvenNumbers.Count);
            Assert.AreEqual(2, result.OddNumbers.Count);
        }
    }
}