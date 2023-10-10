using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KupriyanovEA.Sprint2.Task5.V14.Lib;

namespace Tyuiu.KupriyanovEA.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayName()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Понедельник", ds.FindDayName(1, 1));
            Assert.AreEqual("Вторник", ds.FindDayName(2,1));
            Assert.AreEqual("Среда", ds.FindDayName(3, 1));
            Assert.AreEqual("Четверг", ds.FindDayName(4, 1));
            Assert.AreEqual("Пятница", ds.FindDayName(5, 1));
            Assert.AreEqual("Суббота", ds.FindDayName(6, 1));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7, 1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(-1, -1);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(366, 8);
            });
        }
    }
}
