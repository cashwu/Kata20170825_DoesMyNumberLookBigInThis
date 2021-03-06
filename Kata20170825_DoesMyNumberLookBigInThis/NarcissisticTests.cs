﻿using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170825_DoesMyNumberLookBigInThis
{
    [TestClass]
    public class NarcissisticTests
    {
        [TestMethod]
        public void input_1_should_return_true()
        {
            NarcissisticShouldBeTrue(1);
        }

        [TestMethod]
        public void input_11_should_return_false()
        {
            NarcissisticShouldBeFalse(11);
        }

        [TestMethod]
        public void input_153_should_return_true()
        {
            NarcissisticShouldBeTrue(153);
        }

        private void NarcissisticShouldBeFalse(int value)
        {
            var kata = new Kata();
            var actual = kata.Narcissistic(value);
            Assert.IsFalse(actual);
        }

        private static void NarcissisticShouldBeTrue(int value)
        {
            var kata = new Kata();
            var actual = kata.Narcissistic(value);
            Assert.IsTrue(actual);
        }
    }

    public class Kata
    {
        public bool Narcissistic(int value)
        {
            return value == (int)value.ToString().Sum(n => Math.Pow(char.GetNumericValue(n), value.ToString().Length));
        }
    }
}
