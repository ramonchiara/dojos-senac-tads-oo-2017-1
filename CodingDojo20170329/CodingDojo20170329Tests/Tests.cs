using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingDojo20170329;

namespace CodingDojo20170329Tests
{
    [TestClass]
    public class Tests
    {
        private FizzBuzz fb;

        [TestInitialize]
        public void SetUp()
        {
            fb = new FizzBuzz();
        }

        [TestMethod]
        public void TestConverte1DeveSer1()
        {
            int n = 1;
            string resultado = fb.Converte(n);
            Assert.AreEqual("1", resultado);
        }

        [TestMethod]
        public void TestConverte2DeveSer2()
        {
            int n = 2;
            string resultado = fb.Converte(n);
            Assert.AreEqual("2", resultado);
        }

        [TestMethod]
        public void TestConverte3DeveSerFizz()
        {
            int n = 3;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte4DeveSer4()
        {
            int n = 4;
            string resultado = fb.Converte(n);
            Assert.AreEqual("4", resultado);
        }

        [TestMethod]
        public void TestConverte5DeveSerBuzz()
        {
            int n = 5;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void TestConverte6DeveSerFizz()
        {
            int n = 6;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte7DeveSer7()
        {
            int n = 7;
            string resultado = fb.Converte(n);
            Assert.AreEqual("7", resultado);
        }

        [TestMethod]
        public void TestConverte9DeveSerFizz()
        {
            int n = 9;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte10DeveSerBuzz()
        {
            int n = 10;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void TestConverte11DeveSer11()
        {
            int n = 11;
            string resultado = fb.Converte(n);
            Assert.AreEqual("11", resultado);
        }

        [TestMethod]
        public void TestConverte12DeveSerFizz()
        {
            int n = 12;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte13DeveSer13()
        {
            int n = 13;
            string resultado = fb.Converte(n);
            Assert.AreEqual("13", resultado);
        }

        [TestMethod]
        public void TestConverte15DeveSerFizzBuzz()
        {
            int n = 15;
            string resultado = fb.Converte(n);
            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void TestConverte16DeveSer16()
        {
            int n = 16;
            string resultado = fb.Converte(n);
            Assert.AreEqual("16", resultado);
        }

        [TestMethod]
        public void TestConverte17DeveSer17()
        {
            int n = 17;
            string resultado = fb.Converte(n);
            Assert.AreEqual("17", resultado);
        }
        [TestMethod]
        public void TestConverte18DeveSerFizz()
        {
            int n = 18;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte20DeveSerBuzz()
        {
            int n = 20;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void TestConverte21DeveSerFizz()
        {
            int n = 21;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte30DeveSerFizzBuzz()
        {
            int n = 30;
            string resultado = fb.Converte(n);
            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void TestConverte33DeveSerFizz()
        {
            int n = 33;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void TestConverte35DeveSerBuzz()
        {
            int n = 35;
            string resultado = fb.Converte(n);
            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void TestConverte45DeveSerFizzBuzz()
        {
            int n = 45;
            string resultado = fb.Converte(n);
            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void TestConverte75DeveSerFizzBuzz()
        {
            int n = 75;
            string resultado = fb.Converte(n);
            Assert.AreEqual("FizzBuzz", resultado);
        }
    }
}
