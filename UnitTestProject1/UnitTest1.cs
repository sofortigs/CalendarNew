using System;
using System.IO;
using HomeWork12;
using NUnit.Framework;

namespace HomeWork12Test
{
    [TestFixture]
    public class UnitTestHW12
    {
        [Test]
        public void TestInputDayMethod()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                new Menu().InputDay();

                string result = sw.ToString();
                Assert.AreEqual("Input day of year\r\n", result);
            }
        }
            public void TestInputYearMethod()
            {
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    new Menu().InputYear();

                    string result = sw.ToString();
                    Assert.AreEqual("Input year\r\n", result);
                }
            }
    }
}

