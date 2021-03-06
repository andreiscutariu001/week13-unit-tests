﻿using System;
using NUnit.Framework;
using SimpleStringUtils;

namespace FirstUnitTests
{
    // mai multe atribute aici - https://github.com/nunit/docs/wiki/Attributes
    [TestFixture] // marcheaza clasa ca fiind o clasa ce va contine unit tests
    public class StringUtilsTests
    {
        private StringUtils su;

        [SetUp] // setup pentru partea comuna din teste - initializare sut
        public void Setup()
        {
            su = new StringUtils();
        }

        [TearDown]
        public void TearDown()
        {
            // se apeleaza cand se termina de rulat un test
        }

        [Test] // marcam metoda ca fiind unit test
        public void HelloWorldTest()
        {
            Console.WriteLine("Hello from first unit test");
        }

        [Test]
        public void ReverseTest()
        {
            //arrange
            var input = "ab-cd";
            var expected = "dc-ba";                 //gasit sub numele de expected

            //act
            var actual = su.Reverse(input);         //ce a returnat metoda efectiv

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseTestWithoutLetters()
        {
            //arrange
            var input = "a-bC-dEf-ghIj";
            var expected = "j-Ih-gfE-dCba";             

            //act
            var actual = su.Reverse(input);         

            //assert
            Assert.AreEqual(expected, actual);
        }

        // folosim test cases pentru a nu duplica testele
        // http://dotnetpattern.com/nunit-testcase-example 

        [TestCase("ab-cd", ExpectedResult = "dc-ba")]
        [TestCase("ab-cd-e", ExpectedResult = "e-dc-ba")]
        [TestCase("ab-cd-ef", ExpectedResult = "fe-dc-ba")]
        public string ReverseTestCases(string s)
        {
            //arrange
            var input = s;

            //act
            return su.Reverse(input);
        }

        // Exceptii

        [Test]
        public void ThrowExceptionWhenInputIsEmpty()
        {
            //arrange
            var input = "";

            //act & assert
            // https://github.com/nunit/docs/wiki/Assert.Throws

            Assert.Throws<InvalidOperationException>(() => su.Reverse(input));
            //or (sunt acelasi lucru)

            Assert.Throws(typeof(InvalidOperationException), () => su.Reverse(input));
            // assertam faptul ca se arunca o exceptie de tipul InvalidOperationException cand se apeleaza codul su.Reverse(input)
        }

        [Test]
        public void ThrowExceptionWhenInputIsNull()
        {
            //arrange
            string input = null;

            //act & assert
            Assert.Throws<InvalidOperationException>(() => su.Reverse(input));
        }
    }
}