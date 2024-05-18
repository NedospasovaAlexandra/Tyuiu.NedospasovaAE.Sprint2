using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NedospasovaAE.Sprint2.Task5.V12.Lib;

namespace Tyuiu.NedospasovaAE.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 5;
            int n = 18;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = Convert.ToString(17 + "." + 5 + "." + 2024);
            Assert.AreEqual(wait, res);
        }
    }
}
