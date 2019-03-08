using System;
using NUnit.Framework;
using SimpleStringUtils;

namespace FirstUnitTests
{
    // mai multe atribute aici - https://github.com/nunit/docs/wiki/Attributes
    [TestFixture] // marcheaza clasa ca fiind o clasa ce va contine unit tests
    public class StringUtilsTests
    {
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
            StringUtils su = new StringUtils();

            //act
            var actual = su.Reverse(input);         //ce a returnat metoda efectiv

            //assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ThrowExceptionWhenInputIsEmpty()
        {
            //arrange
            var input = "";
            StringUtils su = new StringUtils();

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
            StringUtils su = new StringUtils();

            //act & assert
            Assert.Throws<InvalidOperationException>(() => su.Reverse(input));
        }

        //[Test]
        //public void ReverseTestWithoutLetters()
        //{
        //    //arrange
        //    var input = "a-bC-dEf-ghIj";
        //    var expected = "j-Ih-gfE-dCba";                 //gasit sub numele de expected
        //    StringUtils su = new StringUtils();

        //    //act
        //    var actual = su.Reverse(input);         //ce a returnat metoda efectiv

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
    }
}