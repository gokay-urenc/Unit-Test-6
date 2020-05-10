using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Asserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double enteredValue = 16;
            const double expected = 4;

            double actual = Math.Sqrt(enteredValue);

            Assert.AreEqual(expected, actual, "{0} sayısının karekökü {1} olmalıdır.", enteredValue, expected);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double expected = 3.1622;
            double delta = 0.0001;

            double actual = Math.Sqrt(10);

            Assert.AreEqual(expected, actual, delta);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string expected = "HELLO";

            string actual = "hello";

            Assert.AreEqual(expected, actual, true); // ignoreCase parametresi küçük büyük harfi duyarlı yapar.
        }

        [TestMethod]
        public void TestMethod4()
        {
            const double unexpected = 0;

            var actual = Math.Pow(5, 0);

            Assert.AreNotEqual(unexpected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var numbers = new byte[] { 1, 2, 3 };

            var otherNumbers = numbers;
            numbers[0] = 4;

            Assert.AreSame(numbers, otherNumbers);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int a = 10;

            int b = a;

            Assert.AreEqual(a, b, "AreEqual hata verdi.");
            Assert.AreNotSame(a, b, "AreSame hata verdi.");
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Bu test yeterli değildir.");
        }

        [TestMethod]
        public void TestMethod8()
        {
            var number = 5m;

            Assert.IsInstanceOfType(number, typeof(decimal));
            Assert.IsNotInstanceOfType(number, typeof(int));
        }

        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }

        [TestMethod]
        public void TestMethod10()
        {
            List<string> numbers = new List<string> { "Coach", "Nick", "Ellis" };

            var theFirstNameThatStartsWithC = numbers.FirstOrDefault(x => x.StartsWith("C"));
            var theFirstNameThatStartsWithS = numbers.FirstOrDefault(x => x.StartsWith("S"));

            Assert.IsNull(theFirstNameThatStartsWithS, "IsNull başarısız oldu.");
            Assert.IsNotNull(theFirstNameThatStartsWithC, "IsNotNull başarısız oldu.");
        }

        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                var number = 5;
                int sonuc = number / 0;
            }
            catch (DivideByZeroException)
            {
                Assert.Fail("Test başarısız oldu");
            }
        }
    }
}