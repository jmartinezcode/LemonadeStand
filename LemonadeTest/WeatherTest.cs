using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade;

namespace LemonadeTest
{
    [TestClass]
    public class WeatherTest
    {
        [TestMethod]
        public void SetCondition_IndexIsZero_ConditionIsSunny()
        {
            Weather weather = new Weather();
            string expected = "Sunny";
            string actual;

            weather.SetCondition(0);
            actual = weather.condition;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetCondition_IndexIsOne_ConditionIsOvercast()
        {
            Weather weather = new Weather();
            string expected = "Overcast";
            string actual;

            weather.SetCondition(1);
            actual = weather.condition;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetCondition_IndexIsTwo_ConditionIsHazy()
        {
            Weather weather = new Weather();
            string expected = "Hazy";
            string actual;

            weather.SetCondition(2);
            actual = weather.condition;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SetCondition_IndexIsThree_ConditionIsRain()
        {
            Weather weather = new Weather();
            string expected = "Rain";
            string actual;

            weather.SetCondition(3);
            actual = weather.condition;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SetCondition_IndexOutOfRange_ExceptionThrown()
        {
            Weather weather = new Weather();

            weather.SetCondition(-1);
        }
    }
}
