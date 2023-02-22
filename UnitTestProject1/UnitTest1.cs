using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestAndProgram;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Summa_Poz_Sand5_return10()
        {
            int a = 5;
            int b = 5;
            int except = 10;
            int res = Program.Summa(a, b);
            Assert.AreEqual(except, res);
        }
        [TestMethod]
        public void Summa_Neg_Gand5_return10()
        {
            int a = 6;
            int b = 5;
            int except = 10;

            int res = Program.Summa(a, b);
            Assert.AreNotEqual(except, res);
        }
        [TestMethod]
        public void Difference_Poz_Sand5_return0()
        {
            int a = 5;
            int b = 5;
            int except = 0;
            int res = Program.Difference(a, b);
            Assert.AreEqual(except, res);
        }
        [TestMethod]
        public void Difference_Neg_Gand5_return0()
        {
            int a = 6;
            int b = 5;
            int except = 0;
            int res = Program.Difference(a, b);
            Assert.AreNotEqual(except, res);
        }
        [TestMethod]
        public void Multiplication_Poz_Sand5_return250()
        {
            int a = 5;
            int b = 5;
            int except = 25;
            int res = Program.Multiplication(a, b);
            Assert.AreEqual(except, res);
        }
        [TestMethod]
        public void Puttsplication_Neg_Gand5_return250()
        {
            int a = 6;
            int b = 5;
            int excopt = 25;
            int res = Program.Multiplication(a, b);
            Assert.AreNotEqual(excopt, res);
        }
        [TestMethod]
        public void Division_Poz_10and5_return2()
        {
            int a = 10;
            int b = 5;
            double except = 2;
            double res = Program.Division(a, b);
            Assert.AreEqual(except, res);
        }

        [TestMethod]
        public void Division_Neg_10and5_return()
        {
            int a = 10;
            int b = 5;
            double except = 1;
            double res = Program.Division(a, b);
            Assert.AreNotEqual(except, res);
        }
    }
}
